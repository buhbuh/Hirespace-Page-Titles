using ApprovalTests;
using ApprovalTests.Reporters;
using FakeItEasy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirespacePageTitles.Tests
{
    [TestFixture]
    public class TitleCreatorTests
    {
        [SetUp]
        public void SetUp()
        {
            TitlesRepository = A.Fake<ITitlesRepository>();
            Sut = new TitleCreator(TitlesRepository);
        }

        public TitleCreator Sut;
        public ITitlesRepository TitlesRepository;

        [Test]
        public void GenerateTitle_GivenShortInputs_CreatesATitleWithAllInputs()
        {
            Page shortPage = new Page { Venue = "v", Space = "s", Use = "u", };
            string title = Sut.GenerateTitle(shortPage);
            Assert.That(title, Is.StringMatching(@"v \| s \| u \| [\w ]+"));
        }

        [Test]
        public void GenerateTitle_GivenChelsea_Creates()
        {
            Page page = new Page { Venue = "Chelsea-Football-Club", Space = "Tambling-Hollins-Bonetti-Clarke-Suites", Use = "Business", };
            string title = Sut.GenerateTitle(page);
            Assert.That(title, Is.EqualTo("Chelsea-Football-Club | Tambling-Hollins | Business"));
        }

        [Test]
        public void GenerateTitle_GivenLongPage_CreatesShortTitle()
        {
            string longText = "1234567890123456-1234567890123456-1234567890123456";
            Page page = new Page { Venue = longText, Space = longText, Use = longText, };

            string title = Sut.GenerateTitle(page);
            
            Assert.That(title, Is.EqualTo(@"1234567890123456 | 1234567890123456 | 1234567890123456"));
        }

        [Test]
        public void GenerateTitle_ReturnsAUniqueTitleNotAlreadyInRepository()
        {
            Page page = new Page { Venue = "venue", Space = "space", Use = "use", };
            string firstTitle = Sut.GenerateTitle(page);
            A.CallTo(() => TitlesRepository.Pages).Returns(new List<Page> { new Page { Title = firstTitle.ToUpper() } });

            string secondTitle = Sut.GenerateTitle(page);

            Assert.That(secondTitle, Is.Not.EqualTo(firstTitle));
        }

        [TestCase("VENUE VENUE VENUE VENUE VENUE VENUE VENUE", "space space", "use use", Result = "VENUE VENUE VENUE VENUE VENUE | space space | use use")]
        [TestCase("venue venue", "SPACE SPACE SPACE SPACE SPACE SPACE SPACE", "use use", Result = "venue venue | SPACE SPACE SPACE SPACE SPACE | use use")]
        [TestCase("venue venue", "space space", "USE USE USE USE USE USE USE USE USE USE", Result = "venue venue | space space | USE USE USE USE USE USE USE")]
        [TestCase("VENUE VENUE VENUE VENUE VENUE VENUE VENUE", "SPACE SPACE SPACE SPACE SPACE SPACE SPACE SPACE", "use use", Result = "VENUE VENUE VENUE VENUE | SPACE SPACE SPACE | use use")]
        public string GenerateTitle_ShortensTheLongestFields(string venue, string space, string use)
        {
            Page page = new Page { Venue = venue, Space = space, Use = use, };
            string result = Sut.GenerateTitle(page);
            return result;
        }

        [Test]
        public void GenerateTitle_GivenLargeDataset_ReturnsNoMoreThan55Characters()
        {
            IEnumerable<Page> pages = MotherObject.Pages();

            List<string> titles = pages.Select(p => Sut.GenerateTitle(p)).ToList();

            foreach(string title in titles)
            {
                Assert.That(title, Has.Length.AtMost(55));
            }
        }

        [Test]
        public void GenerateTitle_GivenLargeDataset_ReturnsHumanReadableContent()
        {
            TitlesRepository.Pages = MotherObject.Pages().ToList();
            StringBuilder result = new StringBuilder();

            foreach (Page page in TitlesRepository.Pages)
            {
                result.AppendLine();
                result.AppendFormat("{0}, {1}, {2}", page.Venue, page.Space, page.Use);
                result.AppendLine();
                page.Title = Sut.GenerateTitle(page);
                result.AppendLine(page.Title);
            }

            Approvals.Verify(result.ToString());
        }

        [Test]
        public void RemoveLastWord_RemovesSimpleCharactors()
        {
            string result = TitleCreator.RemoveLastWord("Hello Bob");
            Assert.That(result, Is.EqualTo("Hello"));
        }

        [Test]
        public void RemoveLastWord_RemovesTrailingPunctuation()
        {
            string result = TitleCreator.RemoveLastWord("Hello, Bob");
            Assert.That(result, Is.EqualTo("Hello"));
        }
    }
}
