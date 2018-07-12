namespace BinaryPlanet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePoemTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (1, 'Fugue Before Lunch')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (2, 'Santa Clara Server Room')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (3, 'Sketch of a Poem in 10 Broken Lines')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (4, 'Brain Imaging')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (5, 'Portrait of a Family as Four Discrete Stanzas')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (6, 'One Night in the Dharma Lounge')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (7, 'From Jersey City With Love & Squalor')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (8, 'Happiness')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (9, 'Years Later, Frank O’Hara')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (10, 'Twilight Zone Reboot')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (11, 'The Sonnosphere [Fragments of a Sci-Fi Epic]')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (12, 'The Convergence')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (13, 'HAL 9000 [A Year Before the Jupiter Launch]')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (14, 'Machine Language')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (15, '30 Second Saga')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (16, 'Action Poem: A Non-Combatants’ Vietnam')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (17, '7 Disappearing Words')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (18, 'And Now a Word From the Management')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (19, 'Last Meal at Blue Earth Cafe')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (20, 'Audio Tour of a Box')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (21, 'What is it like to lose yourself?')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (22, 'Love in the Age of Communism')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (23, 'Sex and its Discontents')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (24, 'Spy Verses Spy [Fragments of a 60’s Spy Novel]')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (25, 'The Singing Commuters')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (26, 'Year of the Shoe')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (27, 'When Victor and Linden got Married')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (28, 'Television is not for Everyone')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (29, 'Oh, Columbia!')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (30, 'Joe McCarthy')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (31, 'Taking the Fall')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (32, 'The Age of Children')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (33, 'Leaving')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (34, 'They Almost Look Like us')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (35, 'Think of the Children')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (36, 'Roadside Reckoning')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (37, 'Saturday Morning')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (38, 'The ZooMonkey')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (39, 'Girl in a Supermarket')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (40, 'Elegy for a Spin Instructor')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (41, 'The Cosmological Constant')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (42, 'Living by Days')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (43, 'The Meaning of Snow')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (44, 'The Art of the Poem')");
            Sql("INSERT INTO Poems (Sequence, Name) VALUES (45, 'The Love Poem of an Average Man')");
        }

        public override void Down()
        {
            Sql("TRUNCATE TABLE Poems");
        }

    }
}
