# Get sdk
FROM mcr.microsoft.com/dotnet/sdk:6.0.412 AS build
WORKDIR /sproject

EXPOSE 5000

# Copy project files
COPY ./*.csproj ./
RUN dotnet restore

# Copiar lo demás
COPY . .
RUN dotnet publish -c Release -o out

# Build image
FROM mcr.microsoft.com/dotnet/sdk:6.0.412
WORKDIR /sproject
COPY --from=build /sproject/out .

ENTRYPOINT [ "dotnet" , "SProject.dll" ]