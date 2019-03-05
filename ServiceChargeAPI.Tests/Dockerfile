FROM microsoft/dotnet:2.2-sdk

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./ServiceChargeAPI.sln ./
COPY ./ServiceChargeAPI/ServiceChargeAPI.csproj ./ServiceChargeAPI/
COPY ./ServiceChargeAPI.Tests/ServiceChargeAPI.Tests.csproj ./ServiceChargeAPI.Tests/

RUN dotnet restore ./ServiceChargeAPI/ServiceChargeAPI.csproj
RUN dotnet restore ./ServiceChargeAPI.Tests/ServiceChargeAPI.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out ServiceChargeAPI.Tests/ServiceChargeAPI.Tests.csproj

CMD dotnet test
