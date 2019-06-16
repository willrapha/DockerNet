# Usa uma imagem do node a partir do docker hub 
FROM node
# Define qual diretório será usado para nossa aplicação no container 
WORKDIR /usr/src/app
# Copia todos os arquivos que começam com package e tem extensão .json para a pasta 
COPY package*.json ./
# Instala todas as dependências declaradas no package.json 
RUN npm install
# Copia todos os arquivos da raiz da nossa aplicação para a pasta definida no WORKDIR 
COPY . .
# Expõe a porta 3000 do container 
EXPOSE 3000
# Roda o comando 'npm start'
CMD [ "npm", "start" ] 