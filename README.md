# Пример архитектуры микросервиса ядра выпускной квалификационной работы
## Описание функционала веб-сервиса
В проекте применена чистая архитектура.
Для хранения данных используется БД PostgreSql.
Для работы доступа к данным применен EF Core PostgreSql.
В проекте используется глобальые фильтры обработки исключения, логгирование ошибок в БД.
Применен паттерн репозиторий , а для CRUD операций используется generic-репозиторий + generic- контроллер.
Для сопоставления dto с моделью данных используется Automapper.
