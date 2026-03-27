FROM mcr.microsoft.com/mssql/server:2022-latest

WORKDIR /app

COPY Db.sql /app/Db.sql
COPY --chmod=755 entrypoint.sh /app/entrypoint.sh

CMD ["/app/entrypoint.sh"]