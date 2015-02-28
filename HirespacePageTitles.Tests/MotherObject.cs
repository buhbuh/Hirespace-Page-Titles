using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirespacePageTitles.Tests
{
    class MotherObject
    {
        public static IEnumerable<Page> Pages()
        {
            return PageData.Split('\n')
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Trim().Split('/'))
                .Select(x => new Page { Venue = x[0], Space = x[1], Use = x[2], });
        }

        private static string PageData = @"

Cally Bemerton Community Hub/Cally Community Football Pitch/Other
Cally Bemerton Community Hub/Cally Community Football Pitch/Film and Photo

The Chelsea Day Spa Hollywood Road/Whole Venue/Venue Hire
The Chelsea Day Spa Hollywood Road/Whole Venue/Package

The Redmond Community Centre/Kitchen/Other
The Redmond Community Centre/Kitchen/Other

Radisson Blu Edwardian Grafton/Warren Suite/Business
Radisson Blu Edwardian Grafton/Warren Suite/Events

Searcys Knightsbridge 30 Pavilion Road/Whole Venue/Business
Searcys Knightsbridge 30 Pavilion Road/Whole Venue/Weddings
Searcys Knightsbridge 30 Pavilion Road/Whole Venue/Events

Abbotsfield School for Boys/Abbotsfield School for Boys/Business
Abbotsfield School for Boys/Abbotsfield School for Boys/Weddings
Abbotsfield School for Boys/Abbotsfield School for Boys/Events
Abbotsfield School for Boys/Abbotsfield School for Boys/Film and Photo
Abbotsfield School for Boys/Abbotsfield School for Boys/Arts

Whitworth Hall/The Whitworth Building Manchester/Weddings
Whitworth Hall/The Whitworth Building Manchester/Dining
Whitworth Hall/The Whitworth Building Manchester/Business
Whitworth Hall/The Whitworth Building Manchester/Events

Cally Bemerton Community Hub/Jean Stokes Community Hall/Business
Cally Bemerton Community Hub/Jean Stokes Community Hall/Events
Cally Bemerton Community Hub/Jean Stokes Community Hall/Arts

Price Studios Ltd/Studio 2 Rehearsals Castings Photography/Business
Price Studios Ltd/Studio 2 Rehearsals Castings Photography/Events
Price Studios Ltd/Studio 2 Rehearsals Castings Photography/Film and Photo
Price Studios Ltd/Studio 2 Rehearsals Castings Photography/Rehearsal
Price Studios Ltd/Studio 1 Theatre TV Film Rehearsals Photography/Dance Rehearsal

Doubletree by Hilton London Westminster/Sky Lounge/Business
Doubletree by Hilton London Westminster/Sky Lounge/Events
Doubletree by Hilton London Westminster/Sky Lounge/Dining

Southbank Centre/Queen Elizabeth Hall Auditorium/Business
Southbank Centre/Queen Elizabeth Hall Auditorium/Arts

Imperial War Museum North IWM North/Harrier Jump Jet Gallery/Business
Imperial War Museum North IWM North/Harrier Jump Jet Gallery/Events

The Westbury Hotel Mayfair/Westbury Gallery First Floor/Events
The Westbury Hotel Mayfair/Westbury Gallery Second Floor/Events

The Lowry Hotel/Meeting Rooms one five and six/Business
The Lowry Hotel/Meeting Rooms one five and six/Events

Pavilion Emirates Old Trafford Lancashire County Cricket Club/The 1864 Suite/Business
Pavilion Emirates Old Trafford Lancashire County Cricket Club/The 1864 Suite/Events

Salford Museum and Art Gallery/Lark Hill Place/Events
Salford Museum and Art Gallery/Lark Hill Place/Dining

Southbank Centre/Royal Festival Hall Auditorium/Business
Southbank Centre/Royal Festival Hall Auditorium/Arts

Harvey Nichols/The Second Floor Bar Brasserie/Business
Harvey Nichols/The Second Floor Bar Brasserie/Weddings
Harvey Nichols/The Second Floor Bar Brasserie/Events

Brasserie Blanc Southbank/Large Private dining room/Business
Brasserie Blanc Southbank/Large Private dining room/Weddings
Brasserie Blanc Southbank/Large Private dining room/Events

Hampstead Heath Station/Hampstead Heath Concourse/Distribution
Hampstead Heath Station/Hampstead Heath Concourse/Exhibitions

Museum of Science and Industry MOSI/Garratt Suite/Business
Museum of Science and Industry MOSI/Garratt Suite/Weddings

Radisson Blu Edwardian Manchester/Halle Suite/Business
Radisson Blu Edwardian Manchester/Halle Suite/Events
Radisson Blu Edwardian Manchester/Halle Suite/Weddings

Radisson Blu Edwardian Manchester/Opus One Bar and Restaurant/Events
Radisson Blu Edwardian Manchester/Opus One Bar and Restaurant/Dining

Andaz Liverpool Street/Great Eastern Suite/Business
Andaz Liverpool Street/Great Eastern Suite/Weddings

Pavilion Emirates Old Trafford Lancashire County Cricket Club/Executive Boxes/Events
Pavilion Emirates Old Trafford Lancashire County Cricket Club/Executive Boxes/Dining

The Bell House/Basement Party Conference Hall/Business
The Bell House/Basement Party Conference Hall/Events
The Bell House/Basement Party Conference Hall/Dining

Manchester Craft and Design Centre/Central Atrium/Weddings
Manchester Craft and Design Centre/Central Atrium/Events
Manchester Craft and Design Centre/Central Atrium/Arts

The Liverpool Everyman Theatre/EV 1 Studio/Business
The Liverpool Everyman Theatre/EV 1 Studio/Film and Photo

The Liverpool Everyman Theatre/EV 2 Meeting Function Room/Business
The Liverpool Everyman Theatre/EV 2 Meeting Function Room/Events

Leighton House Museum/Leighton House Museum/Film and Photo
Leighton House Museum/Leighton House Museum/Business

Royal Over Seas League ROSL/The Garden/Events
Royal Over Seas League ROSL/The Garden/Events

The Cheshire Cookery School/The Cookery School/Events
The Cheshire Cookery School/The Cookery School/Business

Museum of Science and Industry MOSI/Power Hall/Weddings
Museum of Science and Industry MOSI/Power Hall/Events

Liverpool Quaker Meeting House/Networking public space/Business
Liverpool Quaker Meeting House/Networking public space/Events
Liverpool Quaker Meeting House/Networking public space/Arts

Great John Street Hotel/The Library Terrace/Business
Great John Street Hotel/The Library Terrace/Events
Great John Street Hotel/The Library Terrace/Dining

Paternoster Chop House/Temple Bar Private Dining Room/Business
Paternoster Chop House/Temple Bar Private Dining Room/Events
Paternoster Chop House/Temple Bar Private Dining Room/Dining

The Redmond Community Centre/Meeting Room 1/Other
The Redmond Community Centre/Meeting Room 1/Other

Rothbury Hall Stream Arts/Rothbury Hall/Commercial
Rothbury Hall Stream Arts/Rothbury Hall/Non Commercial

Top/London/Wish List St Mungos
Top/London/wish list st mungos

Shoreditch High Street Station/The Concourse/Distribution
Shoreditch High Street Station/The Concourse/Exhibitions

Charis Centre Jesus Church Forty Hill/The Main Hall/Business
Charis Centre Jesus Church Forty Hill/The Main Hall/Weddings
Charis Centre Jesus Church Forty Hill/The Main Hall/Events

The Village Church Farm/Haven House Exhibition Hall/Business
The Village Church Farm/Haven House Exhibition Hall/Events
The Village Church Farm/Haven House Exhibition Hall/Arts

Finchley Road Frognal Station/Finchley Road Frognal Concourse/Distribution
Finchley Road Frognal Station/Finchley Road Frognal Concourse/Exhibitions

Emirates Old Trafford Lancashire County Cricket Club/The Point/Business
Emirates Old Trafford Lancashire County Cricket Club/The Point/Weddings
Emirates Old Trafford Lancashire County Cricket Club/The Point/Events

Great John Street Hotel/Rooftop Lounge Terrace/Events
Great John Street Hotel/Rooftop Lounge Terrace/Weddings

Brasserie Blanc Threadneedle Street/Private Mezzanine/Events
Brasserie Blanc Threadneedle Street/Private Mezzanine/Dining

Sheldrakes Restaurant/Upper Duck viewing gallery/Business
Sheldrakes Restaurant/Upper Duck viewing gallery/Weddings

Herbert Berger at Innholders Hall/New Court Room/Room Hire Rate
Herbert Berger at Innholders Hall/New Court Room/Delegate Rate

Lutyens Restaurant/St John the EvangelistGreat Dixter/Events
Lutyens Restaurant/St John the EvangelistGreat Dixter/Business
Lutyens Restaurant/St John the EvangelistGreat Dixter/Events

Quality Hotel Wembley/Empire Conference Hall/Dry Hire
Quality Hotel Wembley/Empire Conference Hall/With Catering

Top/London/Affordable Wedding Venues London
Top/london/Affordable Wedding Venues London

Imperial War Museum North IWM North/Exclusive Hire/Business
Imperial War Museum North IWM North/Exclusive Hire/Events
Imperial War Museum North IWM North/Exclusive Hire/Dining

Cupcake Family Club Slice Studios/Holistic Den/Events
Cupcake Family Club Slice Studios/Holistic Den/Film and Photo
Cupcake Family Club Slice Studios/Holistic Den/Arts

Pavilion Emirates Old Trafford Lancashire County Cricket Club/Brown Shipley Club Suite/Business
Pavilion Emirates Old Trafford Lancashire County Cricket Club/Brown Shipley Club Suite/Events

Chelsea Football Club/Frankies Sports Bar Diner/Events
Chelsea Football Club/Frankies Sports Bar Diner/Dining

Peoples History Museum/Coal Store Conference Room/Business
Peoples History Museum/Coal Store Conference Room/Events

Somerset House/The Edward J Safra Fountain Court/Events
Somerset House/The Edward J Safra Fountain Court/Film and Photo
Somerset House/The Edward J Safra Fountain Court/Arts

Camden Road Station/Camden Road Concourse/Distribution
Camden Road Station/Camden Road Concourse/Exhibition

Dalston Kingsland Station/Dalston Kingsland Concourse/Distribution
Dalston Kingsland Station/Dalston Kingsland Concourse/Exhibitions

The Crepe Shop Art Cafe/Rustic Art Gallery Basement in Whitechapel E1/Business
The Crepe Shop Art Cafe/Rustic Art Gallery Basement in Whitechapel E1/Screenings
The Crepe Shop Art Cafe/Rustic Art Gallery Basement in Whitechapel E1/Arts

Imperial Wharf Station/Imperial Wharf Concourse/Exhibitions
Imperial Wharf Station/Imperial Wharf Concourse/Distribution

The Magazine Restaurant/The Magazine Restaurant/Business
The Magazine Restaurant/The Magazine Restaurant/Events
The Magazine Restaurant/The Magazine Restaurant/Dining

ArcelorMittal Orbit/ArcelorMittal Orbit Viewing Platforms/Weddings
ArcelorMittal Orbit/ArcelorMittal Orbit Viewing Platforms/Events
ArcelorMittal Orbit/ArcelorMittal Orbit Viewing Platforms/Dining

Castlehaven Community Association/Haven Cafe/Business
Castlehaven Community Association/Haven Cafe/Screenings

Brent Cross Shopping Centre/Promotional Space Mall 2/Promotions
Brent Cross Shopping Centre/Promotional Space Mall 5 B/Promotions
Brent Cross Shopping Centre/Promotional Space East Mall 2/Promotions
Brent Cross Shopping Centre/Promotional Space West Mall 2/Promotions
Brent Cross Shopping Centre/Promotional Space Centre Court/Promotions

Curdridge Reading Room Recreational Ground/Main Hall/Weddings
Curdridge Reading Room Recreational Ground/Main Hall/Events
Curdridge Reading Room Recreational Ground/Main Hall/Arts

Imperial War Museum North IWM North/Main Exhibition Space/Business
Imperial War Museum North IWM North/Main Exhibition Space/Events
Imperial War Museum North IWM North/Main Exhibition Space/Dining

Royal Institution Venue/The Conversation Room/Weddings
Royal Institution Venue/The Conversation Room/Events

Marriott West India Quay/West India Ballroom/Business
Marriott West India Quay/West India Ballroom/Weddings

Radisson Blu Edwardian Manchester/Walters Suite/Business
Radisson Blu Edwardian Manchester/Walters Suite/Events

AJ Bell Players Media Centre Emirates Old Trafford Lancashire Count Cricket Club/Press Lounge/Business
AJ Bell Players Media Centre Emirates Old Trafford Lancashire Count Cricket Club/Press Gallery/Business

The Redmond Community Centre/ICT Suite/Other
The Redmond Community Centre/ICT Suite/Other

British Museum/The Hugh Catherine Stevenson Lecture Theatre/Business
British Museum/The Hugh Catherine Stevenson Lecture Theatre/Events

All Star Lanes Brick Lane/The Penthouse private bowling room/Business
All Star Lanes Brick Lane/The Penthouse private bowling room/Events

Great John Street Hotel/The Kitchen Mezzanine/Events
Great John Street Hotel/The Kitchen Mezzanine/Dining

All Star Lanes Bayswater/The Lodge private bowling room/Business
All Star Lanes Bayswater/The Lodge private bowling room/Weddings
All Star Lanes Bayswater/The Lodge private bowling room/Events

Chiswell Street Dining Rooms/Grubb Street Private Room/Business
Chiswell Street Dining Rooms/Grubb Street Private Room/Events
Chiswell Street Dining Rooms/Grubb Street Private Room/Dining

Shepherds Bush Station/Shepherds Bush Concourse/Exhibitions
Shepherds Bush Station/Shepherds Bush Concourse/Distribution

The Light ApartHotel Manchester/Duplex Penthouse Suites/Business
The Light ApartHotel Manchester/Duplex Penthouse Suites/Film and Photo

Purley John Fisher Rugby Club/Function Room Grounds/Business
Purley John Fisher Rugby Club/Function Room Grounds/Weddings
Purley John Fisher Rugby Club/Function Room Grounds/Events

The Liverpool Everyman Theatre/The Theatre Bar/Weddings
The Liverpool Everyman Theatre/The Theatre Bar/Events
The Liverpool Everyman Theatre/The Theatre Bar/Dining

The Trap Exchange Theatre Studios/Rehearsal Space/Arts
The Trap Exchange Theatre Studios/Rehearsal Space/Events

London Film Museum Covent Garden/Main Gallery/Business
London Film Museum Covent Garden/Main Gallery/Events

The Royal Society/City of London Rooms One Three/Business
The Royal Society/City of London Rooms One Three/Events
The Royal Society/City of London Rooms One Three/Dining

Coram Childrens Charity Campus/The Charter Room/Business
Coram Childrens Charity Campus/The Charter Room/Events
Coram Childrens Charity Campus/The Charter Room/Dining

Sliced Events at The London Irish Centre/McNamara Suite/Business
Sliced Events at The London Irish Centre/McNamara Suite/Weddings
Sliced Events at The London Irish Centre/McNamara Suite/Events

The La La Private Members Club/YOUR BOOKING/Business
The La La Private Members Club/YOUR BOOKING/Dining

Old Royal Naval College/King William Undercroft/Weddings
Old Royal Naval College/King William Undercroft/Events

Kings College London Strand/Great Hall on the Strand/Business
Kings College London Strand/Great Hall on the Strand/Weddings
Kings College London Strand/Great Hall on the Strand/Events

Charis Centre Jesus Church Forty Hill/Small Meeting Room/Business
Charis Centre Jesus Church Forty Hill/Small Meeting Room/Events

America Square Conference Centre/Cornhill Suite/Business
America Square Conference Centre/Cornhill Suite/Arts

Albert Square Chop House/Thomas Worthington Room/Business
Albert Square Chop House/Thomas Worthington Room/Events
Albert Square Chop House/Thomas Worthington Room/Dining

Hilton London Syon Park/Grand Syon Ballroom/Business
Hilton London Syon Park/Grand Syon Ballroom/Weddings

The Old Queens Head/The Victorian Living Room/Events
The Old Queens Head/The Victorian Living Room/Filming and Photography

The Light ApartHotel Manchester/Platinum Penthouse with Roof Terrace/Events
The Light ApartHotel Manchester/Platinum Penthouse with Roof Terrace/Film and Photo
The Light ApartHotel Manchester/Platinum Penthouse with Roof Terrace/Weddings

Salford Museum and Art Gallery/Welcome Space/Business
Salford Museum and Art Gallery/Welcome Space/Dining

Herbert Berger at Innholders Hall/The Great Hall/Delegate Rate
Herbert Berger at Innholders Hall/The Great Hall/Room Hire Rate
Herbert Berger at Innholders Hall/The Great Hall/Christmas Package

The Gate Cinema Notting Hill/Main auditorium/Business
The Gate Cinema Notting Hill/Main auditorium/Film and Photo
The Gate Cinema Notting Hill/Main auditorium/Screenings

AJ Bell Stadium/The Irlam Cadishead and Barton Lounges/Business
AJ Bell Stadium/The Irlam Cadishead and Barton Lounges/Events
AJ Bell Stadium/The Irlam Cadishead and Barton Lounges/Weddings

The International Anthony Burgess Foundation/The Engine House/Events
The International Anthony Burgess Foundation/The Engine House/Screenings
The International Anthony Burgess Foundation/The Engine House/Arts

Macdonald Manchester Hotel Spa/Piccadilly Suite/Business
Macdonald Manchester Hotel Spa/Piccadilly Suite/Events

West Midland Safari Park/Spring Grove House/Business
West Midland Safari Park/Spring Grove House/Weddings

Castlehaven Community Association/Recording Studio/Events
Castlehaven Community Association/Recording Studio/Arts

Cally Bemerton Community Hub/Cally Resource Centre/Business
Cally Bemerton Community Hub/Cally Resource Centre/Screenings

Eccleston Square Hotel/The Media Lounge/Meetings DDR1
Eccleston Square Hotel/The Media Lounge/Meetings DDR2
Eccleston Square Hotel/The Media Lounge/Meetings DDR3

Radisson Blu Edwardian Grafton/Grafton Suite/Business
Radisson Blu Edwardian Grafton/Grafton Suite/Events

Museum of Brands Packaging and Advertising/Conference room/Business
Museum of Brands Packaging and Advertising/Conference room/Screenings

Chiswell Street Dining Rooms/Cornwallis Room/Business
Chiswell Street Dining Rooms/Cornwallis Room/Dining

Dalston Junction Station/Dalston Junction Concourse/Distribution
Dalston Junction Station/Dalston Junction Concourse/Exhibition

Liverpool Quaker Meeting House/Small Meeting Room/Business
Liverpool Quaker Meeting House/Small Meeting Room/Events
Liverpool Quaker Meeting House/Small Meeting Room/Arts

Westminster Boating Base/Pavilion Edgson room/Weddings
Westminster Boating Base/Pavilion Edgson room/Events
Westminster Boating Base/Pavilion Edgson room/Dining

West Midland Safari Park/Tree Tops Pavilion/Business
West Midland Safari Park/Tree Tops Pavilion/Weddings

Grosvenor G Casino Piccadilly/Private Function Room/Meetings
Grosvenor G Casino Piccadilly/Private Function Room/Events

Salvador Amanda Covent Garden/Whole Venue/Weddings
Salvador Amanda Covent Garden/Whole Venue/Events
Salvador Amanda Covent Garden/Whole Venue/Dining

Chiswell Street Dining Rooms/The Snug Main Restaurant/Business
Chiswell Street Dining Rooms/The Snug Main Restaurant/Events
Chiswell Street Dining Rooms/The Snug Main Restaurant/Dining

41 Portland Place/Council Chamber Reception/Business
41 Portland Place/Council Chamber Reception/Events
41 Portland Place/Council Chamber Reception/Dining

The Harley Street Therapy Centre/Room B Suite 2/Business
The Harley Street Therapy Centre/Room B Suite 2/Other

DoubleTree by Hilton Manchester Piccadilly/Palaces/Business
DoubleTree by Hilton Manchester Piccadilly/Palaces/Weddings

Liverpool Quaker Meeting House/Large Meeting Room/Business
Liverpool Quaker Meeting House/Large Meeting Room/Events
Liverpool Quaker Meeting House/Large Meeting Room/Arts

Chiswell Street Dining Rooms/Main Restaurant/Weddings
Chiswell Street Dining Rooms/Main Restaurant/Dining

Cupcake Family Club Slice Studios/Oasis Studio/Business
Cupcake Family Club Slice Studios/Oasis Studio/Events
Cupcake Family Club Slice Studios/Oasis Studio/Arts

Grand Connaught Rooms/Grand Hall Balmoral Suite/Business
Grand Connaught Rooms/Grand Hall Balmoral Suite/Weddings
Grand Connaught Rooms/Grand Hall Balmoral Suite/Events

Manchester Art Gallery/Pre Raphaelite Galleries/Business
Manchester Art Gallery/Pre Raphaelite Galleries/Events
Manchester Art Gallery/Pre Raphaelite Galleries/Weddings

Imperial College Sherfield Building/Queens Tower Rooms/Business
Imperial College Sherfield Building/Queens Tower Rooms/Events
Imperial College Sherfield Building/Queens Tower Rooms/Events

Doubletree by Hilton London Westminster/1st Floor DoubleTree Westminster/Business
Doubletree by Hilton London Westminster/1st Floor DoubleTree Westminster/Events
Doubletree by Hilton London Westminster/1st Floor DoubleTree Westminster/Dining

Herbert Berger at Innholders Hall/Old Court Room/Delegate Rate
Herbert Berger at Innholders Hall/Old Court Room/Room Hire Rate
Herbert Berger at Innholders Hall/Old Court Room/Christmas Package

The Redmond Community Centre/Main Hall/Other
The Redmond Community Centre/Main Hall/Other

Royal Over Seas League ROSL/The Princess Alexandra Hall/Events
Royal Over Seas League ROSL/The Hall of India and Pakistan/Events

Chethams School of Music and Chethams Library/Baronial Hall/Business
Chethams School of Music and Chethams Library/Baronial Hall/Weddings
Chethams School of Music and Chethams Library/Baronial Hall/Dining

Mary Ward House Conference and Exhibition Centre/Virginia Wolf/Business
Mary Ward House Conference and Exhibition Centre/Virginia Wolf/Events

Manchester Marriott Victoria and Albert Hotel/1844/Business
Manchester Marriott Victoria and Albert Hotel/1844/Dining

Latelier des Chefs Oxford Circus/Whole Venue/Dry Hire
Latelier des Chefs Oxford Circus/Whole Venue/Corporate Events

The Liverpool Everyman Theatre/The Rehearsal Room/Business
The Liverpool Everyman Theatre/The Rehearsal Room/Arts

Hilton London Tower Bridge/Meeting Room 234/Business
Hilton London Tower Bridge/Meeting Room 234/Events
Hilton London Tower Bridge/Meeting Room 234/Dining

All Star Lanes Manchester/The Jungle Room private bowling room/Business
All Star Lanes Manchester/The Jungle Room private bowling room/Weddings
All Star Lanes Manchester/The Jungle Room private bowling room/Events

Made In Hackney Local Food Kitchen/The Kitchen/Cooking
Made In Hackney Local Food Kitchen/The Kitchen/Photography

Sliced Events at The London Irish Centre/Chapel Suite/Business
Sliced Events at The London Irish Centre/Chapel Suite/Weddings
Sliced Events at The London Irish Centre/Chapel Suite/Arts

Baa Bar Deansgate Locks/Baa Bar Full Venue Hire/Business
Baa Bar Deansgate Locks/Baa Bar Full Venue Hire/Events
Baa Bar Deansgate Locks/Baa Bar Full Venue Hire/Pop up

The Stay ClubWillesden Junction/The Stay Academy/Business
The Stay ClubWillesden Junction/The Stay Academy/Pop up
The Stay ClubWillesden Junction/The Stay Academy/Other

Cupcake Family Club Slice Studios/Cafe Area/Events
Cupcake Family Club Slice Studios/Cafe Area/Pop up

Royal Liver Building/The Venue at the Royal Liver Building/Business
Royal Liver Building/The Venue at the Royal Liver Building/Weddings
Royal Liver Building/The Venue at the Royal Liver Building/Events

Manchester Marriott Victoria and Albert Hotel/John Logie Baird Suite/Business
Manchester Marriott Victoria and Albert Hotel/John Logie Baird Suite/Events
Manchester Marriott Victoria and Albert Hotel/John Logie Baird Suite/Dining

Royal Northern College of Music/RNCM Concert Hall available from Jan 2015/Business
Royal Northern College of Music/RNCM Concert Hall available from Jan 2015/Arts

The Northern Quarter Restaurant and Bar/Whole Venue/Events
The Northern Quarter Restaurant and Bar/Whole Venue/Dining

Rileys Sports Bar Haymarket/The VIP Lounge/Business
Rileys Sports Bar Haymarket/The VIP Lounge/Events
Rileys Sports Bar Haymarket/The VIP Lounge/Screenings

The Waldorf Hilton Hotel/Executive boardroom/Business
The Waldorf Hilton Hotel/Executive boardroom/Dining

Amazing Grace Worship Centre/First Floor Hall/Business
Amazing Grace Worship Centre/First Floor Hall/Events

Royal Garden Hotel/York Suite Lancaster Suite Berties Bar/Business
Royal Garden Hotel/York Suite Lancaster Suite Berties Bar/Events
Royal Garden Hotel/York Suite Lancaster Suite Berties Bar/Dining

The Light ApartHotel Manchester/Penthouse Suites/Business
The Light ApartHotel Manchester/Penthouse Suites/Film and Photo

Radisson Blu Edwardian Grafton/Harlington Suite/Business
Radisson Blu Edwardian Grafton/Harlington Suite/Events

Chethams School of Music and Chethams Library/Staff Dining Room/Business
Chethams School of Music and Chethams Library/Staff Dining Room/Dining

Royal Northern College of Music/Carole Nash Recital Room/Business
Royal Northern College of Music/Carole Nash Recital Room/Events
Royal Northern College of Music/Carole Nash Recital Room/Arts

Isla Gladstone Conservatory/Isla Gladstone Conservatory/Business
Isla Gladstone Conservatory/Isla Gladstone Conservatory/Weddings
Isla Gladstone Conservatory/Isla Gladstone Conservatory/Events

DoubleTree by Hilton Manchester Piccadilly/Skylounge/Weddings
DoubleTree by Hilton Manchester Piccadilly/Skylounge/Events
DoubleTree by Hilton Manchester Piccadilly/Skylounge/Dining

Top/London/Venue Finding Agency
Top/london/Venue Finding Agency

The Cheshire Cookery School/The Demonstration Room/Film and Photo
The Cheshire Cookery School/The Demonstration Room/Pop up

The Royal Society/Wellcome Trust Lecture Hall/Business
The Royal Society/Wellcome Trust Lecture Hall/Events
The Royal Society/Wellcome Trust Lecture Hall/Dining

Macdonald Manchester Hotel Spa/Meeting Rooms 1 2 6 8 9 10/Business
Macdonald Manchester Hotel Spa/Meeting Rooms 3 4 5 7/Business

Old Royal Naval College/Queen Mary Undercroft/Weddings
Old Royal Naval College/Queen Mary Undercroft/Events

The Safehouses Maverick Project/Safehouse 1/Film and Photo
The Safehouses Maverick Project/Safehouse 1/Pop up

Top/London/Promotional Spaces London
Top/london/Promotional Spaces London

Castlehaven Community Association/Dance Studio/Events
Castlehaven Community Association/Dance Studio/Film and Photo

Liverpool Quaker Meeting House/Institute Room/Business
Liverpool Quaker Meeting House/Institute Room/Events

Grand Connaught Rooms/Edinburgh Drawing Room/Business
Grand Connaught Rooms/Edinburgh Drawing Room/Weddings
Grand Connaught Rooms/Edinburgh Drawing Room/Events

Grosvenor G Casino Didsbury/Gallery Restaurant/Business
Grosvenor G Casino Didsbury/Gallery Restaurant/Dining

British Museum/The Raymond Beverly Sackler Rooms/Business
British Museum/The Raymond Beverly Sackler Rooms/Events

All Star Lanes Holborn/The Trophy Room private bowling room/Business
All Star Lanes Holborn/The Trophy Room private bowling room/Events
All Star Lanes Holborn/The Trophy Room private bowling room/Film and Photo

Great John Street Hotel/Boys Girls Classrooms/Business
Great John Street Hotel/Boys Girls Classrooms/Events

Chethams School of Music and Chethams Library/Audit Room/Business
Chethams School of Music and Chethams Library/Audit Room/Dining

The Lowry Hotel/Meeting Rooms 234 Meeting Rooms 78/Business
The Lowry Hotel/Meeting Rooms 234 Meeting Rooms 78/Weddings
The Lowry Hotel/Meeting Rooms 234 Meeting Rooms 78/Dining

Cally Bemerton Community Hub/Bemerton Art Workshops/Business
Cally Bemerton Community Hub/Bemerton Art Workshops/Pop up
Cally Bemerton Community Hub/Bemerton Art Workshops/Arts

Top/London/Wish List Tanwens Birthday
Top/London/wish list tanwens birthday

Kent House Knightsbridge/The North and South Sanctuary/Weddings
Kent House Knightsbridge/The North and South Sanctuary/Events
Kent House Knightsbridge/The North and South Sanctuary/Dining

The Liverpool Everyman Theatre/Everyman Theatre Auditorium/Business
The Liverpool Everyman Theatre/Everyman Theatre Auditorium/Events
The Liverpool Everyman Theatre/Everyman Theatre Auditorium/Arts

8 Northumberland Avenue/The Old Billiard Room Annex/Business
8 Northumberland Avenue/The Old Billiard Room Annex/Events

Cardboard Citizens Rehearsal Studio/Rehearsal Room/Business
Cardboard Citizens Rehearsal Studio/Rehearsal Room/Rehearsals

Imperial War Museum North IWM North/Quayside/Events
Imperial War Museum North IWM North/Quayside/Film and Photo

Museum of Brands Packaging and Advertising/Museum of Brands/Events
Museum of Brands Packaging and Advertising/Museum of Brands/Dining
Museum of Brands Packaging and Advertising/Museum of Brands/Film and Photo

Hotel Russell/Virginia Woolfs Benjamins Suite/Business
Hotel Russell/Virginia Woolfs Benjamins Suite/Weddings
Hotel Russell/Virginia Woolfs Benjamins Suite/Events

Brasserie Blanc Charlotte Street/First Floor exclusive/Events
Brasserie Blanc Charlotte Street/First Floor exclusive/Dining
Brasserie Blanc Charlotte Street/First Floor exclusive/Screenings

Chelsea Football Club/Tambling Hollins Bonetti Clarke Suites/Business
Chelsea Football Club/Tambling Hollins Bonetti Clarke Suites/Events
Chelsea Football Club/Tambling Hollins Bonetti Clarke Suites/Dining
";
    }
}
