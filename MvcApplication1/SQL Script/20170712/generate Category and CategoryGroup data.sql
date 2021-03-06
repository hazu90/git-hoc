USE [VietnameseFoody]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (1, N'Sang trọng', N'sang-trong', 1, N'https://media.foody.vn/caticon/s60x60/foody-12-sangtrong-635950388128057921.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (2, N'Buffet', N'buffet', 1, N'https://media.foody.vn/caticon/s60x60/foody-39-buffet-635950383405966956.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (3, N'Nhà hàng', N'nha-hang', 1, N'https://media.foody.vn/caticon/s60x60/foody-01-restoran-635950389575416940.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (4, N'Ăn vặt/vỉa hè', N'an-vat-via-he', 1, N'https://media.foody.vn/caticon/s60x60/foody-11-anvat-635950388395266822.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (5, N'Ăn chay', N'an-chay', 1, N'https://media.foody.vn/caticon/s60x60/foody-56-anchay-635950379675005450.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (6, N'Café/Dessert', N'cafe', 1, N'https://media.foody.vn/caticon/s60x60/foody-02-kedai%20kopi-635950389484472462.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (7, N'Quán ăn', N'quan-an', 1, N'https://media.foody.vn/caticon/s60x60/foody-03-rumah%20makan-635950389304770706.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (8, N'Bar/Pub', N'bar-pub', 1, N'https://media.foody.vn/caticon/s60x60/foody-04-barpub-635950389189605062.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (9, N'Quán nhậu', N'quan-nhau', 1, N'https://media.foody.vn/caticon/s60x60/foody-54-quannhau-635950379866739193.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (10, N'Beer club', N'beer-club', 1, N'https://media.foody.vn/caticon/s60x60/foody-43-beerclub-635950382429048603.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (11, N'Tiệm bánh', N'tiem-banh', 1, N'https://media.foody.vn/caticon/s60x60/foody-06-tiembanh-635950389009259871.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (12, N'Tiệc tận nơi', N'tiec-tan-noi', 1, N'https://media.foody.vn/caticon/s60x60/foody-44-tiectannoi-635950382223863942.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (13, N'Shop Online', N'shop-online', 1, N'https://media.foody.vn/caticon/s60x60/foody-27-shoponline-635950385288337691.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (14, N'Giao cơm văn phòng', N'giao-com-van-phong', 1, N'https://media.foody.vn/caticon/s60x60/foody-28-comvanphong-635950385047534150.png')
INSERT [dbo].[Category] ([CateId], [CateName], [CateLink], [CateGrId], [IconImgUrl]) VALUES (15, N'Khu Ẩm Thực', N'Foodcourt', 1, N'https://media.foody.vn/caticon/s60x60/foody-64x64_pic-category-khuamthuc-636266402889811778.png')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[CategoryGroup] ON 

INSERT [dbo].[CategoryGroup] ([CateGrId], [CateName], [GrCateLink]) VALUES (1, N'Ăn uống', N'food')
SET IDENTITY_INSERT [dbo].[CategoryGroup] OFF
