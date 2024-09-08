USE [Test]
GO

if SCHEMA_ID('Wrk') is null
exec ('CREATE SCHEMA [Wrk]')
GO


/*****************************************************************************
		[Wrk] tables
*****************************************************************************/

/****** Table [Wrk].[Product] ******/
if not exists(select 1 from sysobjects where xtype='U' 
	and [name]='Product' and [uid] = SCHEMA_ID('Wrk'))
CREATE TABLE [Wrk].[Product](
  [Id] uniqueidentifier NOT NULL DEFAULT NEWSEQUENTIALID(),
  [Name] [nvarchar](50) NOT NULL,
  constraint [PK__WrkProduct__ID] PRIMARY KEY ([Id])
)
GO

/****** Table [Wrk].[Category] ******/
if not exists(select 1 from sysobjects where xtype='U' 
	and [name]='Category' and [uid] = SCHEMA_ID('Wrk'))
CREATE TABLE [Wrk].[Category](
  [Id] uniqueidentifier NOT NULL DEFAULT NEWSEQUENTIALID(),
  [Name] [nvarchar](50) NOT NULL,
  constraint [PK__WrkCategory__ID] PRIMARY KEY ([Id])
)
GO


/****** Table [Wrk].[Relation] ******/
if not exists(select 1 from sysobjects where xtype='U' 
	and [name]='Relation' and [uid] = SCHEMA_ID('Wrk'))
CREATE TABLE [Wrk].[Relation](
  [Id] uniqueidentifier NOT NULL DEFAULT NEWSEQUENTIALID(),
  [CategoryId] [uniqueidentifier] NOT NULL,
  [ProductId] [uniqueidentifier] NOT NULL,
  constraint [PK__WrkRelation__ID] PRIMARY KEY ([Id]),
  CONSTRAINT [FK_WrkRelation_WrkProduct] FOREIGN KEY([ProductId])
    REFERENCES [Wrk].[Product] ([Id]),
  CONSTRAINT [FK_WrkRelation_WrkCategory] FOREIGN KEY([CategoryId])
    REFERENCES [Wrk].[Category] ([Id])
) 
GO
