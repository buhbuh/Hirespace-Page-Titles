using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HirespacePageTitles
{
    public class TitleCreator
    {
        public TitleCreator(ITitlesRepository titlesRepository)
        {
            this.TitlesRepository = titlesRepository;
        }

        private readonly ITitlesRepository TitlesRepository;
        private string[] Phrases = { "Hire Space", "See Pictures", "Enquire Online", "See More", "Enquire Now" };
        private const int MaxLength = 55;

        /// <summary>
        /// Returns a unique title, which does not already exist in the titles repository.
        /// </summary>
        public string GenerateTitle(Page page)
        {
            if(page == null)
            {
                throw new ArgumentNullException("page");
            }

            page = new Page
            {
                Venue = page.Venue,
                Space = page.Space,
                Use = page.Use,
            };

            string uniqueTitle = GenerateTitleCandidates(page)
                    .Where(titleCandidate => titleCandidate.Length <= MaxLength)
                    .Where(titleCandidate => TitlesRepository.Pages.All(p => !string.Equals(p.Title, titleCandidate, StringComparison.OrdinalIgnoreCase)))
                    .First();

            return uniqueTitle;
        }

        /// <summary>
        /// Returns a sequence of titles from which an appropriate title may be chosen
        /// </summary>
        private IEnumerable<string> GenerateTitleCandidates(Page page)
        {
            while (true)
            {
                string title = string.Format(
                     "{0} | {1} | {2}",
                     page.Venue,
                     page.Space,
                     page.Use
                );

                int hashCode = title.GetHashCode();

                for (int i = 0; i < Phrases.Length; i++)
                {
                    string phrase = Phrases[Math.Abs(i + hashCode) % Phrases.Length];
                    yield return title + " | " + phrase;
                }

                yield return title;

                ShortenPageProperties(page);
            }
        }

        /// <summary>
        /// Reduces the overall length of the page.  This logic could be customised to produce different results.
        /// </summary>
        private void ShortenPageProperties(Page page)
        {
            if (page.Venue.Length > page.Space.Length && page.Venue.Length > page.Use.Length)
            {
                string shorterVenue = RemoveLastWord(page.Venue);
                if (!string.IsNullOrWhiteSpace(shorterVenue))
                {
                    page.Venue = shorterVenue;
                    return;
                }
            }

            if (page.Space.Length > page.Use.Length)
            {
                string shorterSpace = RemoveLastWord(page.Space);
                if (!string.IsNullOrWhiteSpace(shorterSpace))
                {
                    page.Space = shorterSpace;
                    return;
                }
            }

            string shorterUse = RemoveLastWord(page.Use);
            if (!string.IsNullOrWhiteSpace(shorterUse))
            {
                page.Use = shorterUse;
                return;
            }

            throw new InvalidOperationException("The page cannot be shortened any further without loss of information.");
        }

        /// <summary>
        /// Returns the text with the last word missing.
        /// </summary>
        public static string RemoveLastWord(string text)
        {
            return Regex.Replace(text, @"\W+\w+\W*$", "");
        }
    }
}
