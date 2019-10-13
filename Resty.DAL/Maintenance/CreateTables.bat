@echo on

cd C:\Program Files (x86)\pgAdmin 4\v4\runtime

pg_dump -U postgres -f C:\Users\Domica\source\repos\Resty\Resty.DAL\Maintenance\database.sql -d Resty