#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat 

#step 1: build frontend
#FROM node:10-alpine as build-frontend
#WORKDIR /app
#COPY frontend .
#RUN npm install
#RUN $(npm bin)/ng build --prod

#
#FROM mcr.microsoft.com/windows/servercore:1803 as installer
#
#SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop';$ProgressPreference='silentlyContinue';"]
#
#RUN Invoke-WebRequest -OutFile nodejs.zip -UseBasicParsing "https://nodejs.org/dist/latest/node-v13.3.0-win-x64.zip"; `
#Expand-Archive nodejs.zip -DestinationPath C:\; `
#Rename-Item "C:\\node-v13.3.0-win-x64" c:\nodejs
#
#FROM mcr.microsoft.com/windows/nanoserver:1803 as build-frontend
#
#WORKDIR C:\nodejs
#COPY --from=installer C:\nodejs\ .
#RUN SETX PATH C:\nodejs
#RUN npm config set registry https://registry.npmjs.org/
#
#WORKDIR /app
#
## install and cache app dependencies
#COPY frontend .
#
##WORKDIR /app/src/WebSpa
#RUN npm install
#RUN npm install -g @angular/cli@latest
#RUN $(npm bin)/ng build --prod

#################################
# add app
#COPY . /app
#
## start app
#CMD cd /app/src/WebSpa && ng serve --host 0.0.0.0
#########################################

#step 2: build backend
#FROM mcr.microsoft.com/dotnet/core/sdk AS build-backend
#RUN mkdir app
#WORKDIR /app
#COPY backend .
#COPY --from=build-frontend /app/dist/frontend/ /wwwroot
#RUN dotnet restore
#RUN dotnet publish -c Release -o out

#step 3: run
#FROM mcr.microsoft.com/dotnet/core/aspnet
#WORKDIR /app
#COPY --from=build-backend /app/out .
#ENTRYPOINT dotnet backend.dll

FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-1803
ARG source
WORKDIR /inetpub/wwwroot
#COPY --from=build-frontend /app/dist/frontend/ .
COPY ${source:-obj/Docker/publish} .
#EXPOSE 1433 80 443
