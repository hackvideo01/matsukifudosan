USE [matsuki]
GO
/****** Object:  Table [dbo].[ImageDB]    Script Date: 2021/08/27 18:26:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImageDB](
	[ImageId] [int] IDENTITY(1,1) NOT NULL,
	[ImageName] [nvarchar](1000) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageType] [nvarchar](50) NULL,
	[HouseNo] [varchar](100) NULL,
 CONSTRAINT [PK__Image__7516F70C5B918074] PRIMARY KEY CLUSTERED 
(
	[ImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ImageDB]  WITH CHECK ADD  CONSTRAINT [FK__Image__HouseNo__7C4F7684] FOREIGN KEY([HouseNo])
REFERENCES [dbo].[RentalManagementDB] ([HouseNo])
GO
ALTER TABLE [dbo].[ImageDB] CHECK CONSTRAINT [FK__Image__HouseNo__7C4F7684]
GO
