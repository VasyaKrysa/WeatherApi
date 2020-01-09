## Task
Variant 2

2. Admin Dashboard 
- As a User I want to see a weather forecast for a specified city in a user-friendly and self-explanatory way. I also want to save a list of predefined places so every time when I open application I have a forecast for these cities. 

Flow described:

- On a main page (called Dashboard from now on) I have a table with a list of cities I selected as preferred ones, I also have an autocomplete control where I can type the name of city and list of suggested options will appear. I'm OK with a limitation for a small armount of cities (10 should be enough). 
- All cities I select as preferred should be persisted in database so I can see them between sessions 
- I can also remove a city from preferred list by clicking on Delete button somewhere in a table.
- In a table I have a button named 'View Forecast'. By clicking on it I expect to be redirected to a dedicated page with a proper route ("(host)/forecast/{city-name}"). There I can see a collection of charts that should display a different weather metrics ("temperature", "pressure", "humidity" etc). 
- Each of this metrics is shown as a chart, I expect to have a different kind or at least style for each metrics shown. 

Required technical stack: .NET Core 3, WEB API, Angular 8+, SQL Server Recommended libraries and APIS: EntityFramework Core, "ngx-charts", https://openweathermap.org/forecast5 as API to get weather forecast itself Notes: List of available cities together with its IDs from Openweathermap API should be stored in a database and used as a data source for Autocomplete 

Acceptance criteria:

- I can specify the list of preferred cities so I can see a weather forecast for them later 
- I can modify this list of preferred cities 
- I can be redirected to a dedicates page where I can see a list of weather foreçast metrics as charts 
- Calls to an OpenWeather API (or its replacement) should be done from Backend side and then sent to a frontend. Attempt to call API directly from Frontend side will be considered as a failed task 

Advanced level requirements:

- Add ability to turn on/off some of the metrics provided by external API and save them to a database 
- Change design in a way that multiple cities forecasts can be shown simultaneously in a same page. Thus if user checks multiple cities - he will see a multiple lines on a same chart.

## ToDo

- в файлі appsettings.json змінити в "DatabaseConection" назву сервера на свою.
- створити базу з допогою update-database в проекті DAL.
- в файлі startup.cs в стрічці 49 змінити налаштування CORS на адресу фронт сторони.

(- позавантажувати потрібні бібліотеки)
