FROM mcr.microsoft.com/dotnet/sdk:6.0 AS server-build-env
WORKDIR ./
COPY . .
RUN dotnet publish "./CertificateChain/CertificateChain.csproj" -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:6.0
RUN mkdir -p /app
WORKDIR /app
COPY --from=server-build-env /app .
ENTRYPOINT ["dotnet", "CertificateChain.dll"]