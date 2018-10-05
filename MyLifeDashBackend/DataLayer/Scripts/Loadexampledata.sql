-- Script Date: 10/5/2018 11:21 AM  - ErikEJ.SqlCeScripting version 3.5.2.75
INSERT INTO [Plugins] ([PluginId] ,[Name]) VALUES  (1  ,'E1');
INSERT INTO [Plugins] ([PluginId] ,[Name]) VALUES  (2  ,'E2');
INSERT INTO [Plugins] ([PluginId] ,[Name]) VALUES  (3  ,'W1');
INSERT INTO [Plugins] ([PluginId] ,[Name]) VALUES  (4  ,'W2');
INSERT INTO [Plugins] ([PluginId] ,[Name]) VALUES  (5  ,'B1');
INSERT INTO [Plugins] ([PluginId] ,[Name]) VALUES  (6  ,'B2');

INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (1, 'Inv 1', 'Inv 1', 423000, 7.02, 1, 1);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (2, 'Inv 2', 'Inv 2', 2400, 4.79, 2, 1);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (3, 'Inv 3', 'Inv 3', 0, 0, 3, 1);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (4, 'Inv 4', 'Inv 4', 10000, 0.49, 4, 1);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (5, 'Fondo 1', 'Fondo 1', 300000, 5.86, 5, 2);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (6, 'Fondo 2', 'Fondo 2', 160000, 5.86, 6, 2);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (7, 'Fondo 3', 'Fondo 3', 60000, 5.86, 7, 2);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (8, 'Fondo 4', 'Fondo 4', 100000, 5.86, 8, 2);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (9, 'Alt 1', 'Alt 1', 0, 0, 9, 3);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (10, 'Alt 2', 'Alt 2', 30000, 0, 10, 4);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (11, 'Bank 1', 'Bank 1', 10000, 0, 11, 5);
INSERT INTO [Sections] ([SectionId] ,[Name] ,[Description] ,[Total] ,[Gain],[ConfigurationRefId] ,[PluginId])
	VALUES (12, 'Bank 2', 'Bank 2', 5000, 0, 12, 6);
	
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (1 ,'' ,10.25);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (2 ,'' ,10.25);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (3 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (4 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (5 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (6 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (7 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (8 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (9 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (10 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (11 ,'' ,0);
INSERT INTO [Configuration] ([ConfigurationId] ,[Name] ,[Taxes] ) VALUES (12 ,'' ,0);
	
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (1 ,100 ,2 ,1);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (2 ,100 ,2 ,4);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (3 ,20 ,2 ,5);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (4 ,80 ,2 ,5);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (5 ,13.2 ,2 ,6);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (6 ,26.8 ,2 ,6);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (7 ,30 ,2 ,6);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (8 ,30 ,2 ,6);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (9 ,100 ,2 ,7);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (10 ,100 ,2 ,8);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (11 ,100 ,2 ,10);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (12 ,100 ,2 ,11);
INSERT INTO [ConfigurationInstruments] ([ConfigurationInstrumentId] ,[Percentaje] ,[CatInstrumentsCatInstrumentId] ,[ConfigurationId])
	VALUES (13 ,100 ,2 ,12);
	
	