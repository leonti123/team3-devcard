# team3-devcard

Сайт-визитка команды с API на C# ASP.NET.

## Команда

| Имя | Роль |
|-----|------|
| Наумов Леонтий | Tech Lead |
| Наумов Леонтий | Developer |
| Наумов леонтий | QA |

## Как запустить

### Бэкенд (API)
cd backend/TeamApi
dotnet run

API будет доступен по адресу: http://localhost:5080

Эндпоинты:
- GET /api/team — список участников
- GET /api/team/{name} — участник по имени
- GET /api/ping — проверка работы API

### Фронтенд
Открой frontend/index.html в браузере (при запущенном бэкенде).
