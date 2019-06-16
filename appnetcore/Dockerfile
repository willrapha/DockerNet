# define a imagem base  
FROM microsoft/dotnet:2.1-sdk
# define o diretório de trabalho no contêiner 
WORKDIR /app
# copia o arquivo csproj e restaura as camadas 
COPY *.csproj ./
# restaura as dependências do projeto RUN dotnet restore
RUN dotnet restore 
# copia tudo da pasta atual para o contêiner 
COPY . ./ 
# executa o comando que publica o projeto na pasta out 
RUN dotnet publish -c Release -o out
# executa o comando dotnet no arquivo do projeto na pasta out 
ENTRYPOINT ["dotnet", "out/projetos.dll"] 