FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY bin/Debug/netcoreapp3.1 App/
WORKDIR /App
ENTRYPOINT [ "dotnet", "patryk.konopka.service2.dll" ]