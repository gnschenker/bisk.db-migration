FROM mcr.microsoft.com/dotnet/core/sdk:2.2
WORKDIR /app
COPY api/api.csproj ./
RUN dotnet restore
COPY api .
RUN dotnet build
EXPOSE 5000
CMD dotnet run