# get the base image to build upon
FROM mcr.microsoft.com/dotnet/sdk:3.1.426-alpine3.16 AS build
# set the working directory to /app
WORKDIR /app

# copy csproj and restore as distinct layers
COPY code/code.csproj ./
RUN dotnet restore

# copy and publish app and libraries
COPY code/. ./
RUN dotnet publish -c Release -o out

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:3.1.19-alpine3.13
WORKDIR /app
COPY --from=build /app/out ./

# start the app
ENTRYPOINT ["dotnet", "code.dll"]
