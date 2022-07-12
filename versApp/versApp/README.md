# Versta
Web-приложение. Тестовое задание.
# Как запустить проект
После скачивания проекта необходимо загрузить БД из backup (файл testApp.bak) и в файле appsettings.json изменить имя сервера на имя вашего сервера.
# Технологии
Для создания данного приложения были использованны:
- ASP.NET Core
- ASP.NET MVC
- Entity Framework Core
- Sql Server
# Если не удается загрузить БД из backup
В таком случае необходимо создать БД и для нее выполнить следуюший запрос для создания таблицы:
CREATE TABLE [dbo].[Order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CitySender] [nchar](100) NOT NULL,
	[AddressSender] [nchar](400) NOT NULL,
	[CityRecipient] [nchar](100) NOT NULL,
	[AddressRecipient] [nchar](400) NOT NULL,
	[Weigth] [float] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

После изменить строку подключения в файле appsettings.json


