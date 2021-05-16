#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Deposito.Application/Deposito.Application.csproj", "Deposito.Application/"]
COPY ["Deposito.Repository/Deposito.Repository.csproj", "Deposito.Repository/"]
COPY ["Deposito.Domain/Deposito.Domain.csproj", "Deposito.Domain/"]
COPY ["Deposito.Business/Deposito.Business.csproj", "Deposito.Business/"]
COPY ["Deposito.Services/Deposito.Services.csproj", "Deposito.Services/"]
RUN dotnet restore "Deposito.Application/Deposito.Application.csproj"
COPY . .
WORKDIR "/src/Deposito.Application"
RUN dotnet build "Deposito.Application.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Deposito.Application.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "Deposito.Application.dll"]

RUN useradd -m myappuser
USER myappuser

CMD ASPNETCORE_URLS=http://*:$PORT dotnet Deposito.Application.dll