FROM mcr.microsoft.com/mssql/server:2022-latest

ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=YourStrong!Passw0rd

WORKDIR /app

COPY Db.sql /app/Db.sql
COPY --chmod=755 entrypoint.sh /app/entrypoint.sh

CMD ["/app/entrypoint.sh"]