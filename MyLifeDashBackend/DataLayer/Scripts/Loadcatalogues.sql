-- Script Date: 10/3/2018 2:32 PM  - ErikEJ.SqlCeScripting version 3.5.2.75
INSERT INTO [CatInstruments] ([Id],[Name])
SELECT * FROM (SELECT 1, 'Savings') AS tmp WHERE NOT EXISTS ( SELECT [Name] FROM [CatInstruments] WHERE [Id] = 1 ) LIMIT 1;

INSERT INTO [CatInstruments] ([Id],[Name])
SELECT * FROM (SELECT 2, 'Equity MX') AS tmp WHERE NOT EXISTS ( SELECT [Name] FROM [CatInstruments] WHERE [Id] = 2 ) LIMIT 1;

INSERT INTO [CatInstruments] ([Id],[Name])
SELECT * FROM (SELECT 3, 'Debt MX') AS tmp WHERE NOT EXISTS ( SELECT [Name] FROM [CatInstruments] WHERE [Id] = 3 ) LIMIT 1;

INSERT INTO [CatInstruments] ([Id],[Name])
SELECT * FROM (SELECT 4, 'Others MX') AS tmp WHERE NOT EXISTS ( SELECT [Name] FROM [CatInstruments] WHERE [Id] = 4 ) LIMIT 1;

INSERT INTO [CatInstruments] ([Id],[Name])
SELECT * FROM (SELECT 5, 'Equity Tech USA') AS tmp WHERE NOT EXISTS ( SELECT [Name] FROM [CatInstruments] WHERE [Id] = 5 ) LIMIT 1;

INSERT INTO [CatInstruments] ([Id],[Name])
SELECT * FROM (SELECT 6, 'Equity USA') AS tmp WHERE NOT EXISTS ( SELECT [Name] FROM [CatInstruments] WHERE [Id] = 6 ) LIMIT 1;

INSERT INTO [CatInstruments] ([Id],[Name])
SELECT * FROM (SELECT 7, 'Debt USA') AS tmp WHERE NOT EXISTS ( SELECT [Name] FROM [CatInstruments] WHERE [Id] = 7 ) LIMIT 1;
