## Um app de limpeza de pastas batizado provisoriamente de `Talpidae`
Um programa simpleszinho que eu uso para excluir alguns arquivos antes de fazer o backup dos meus projetos, geralmente excluo pastas/arquivos como `node_modules`, arquivos `.exe`, etc.

## Como rodar?
Precisa ter o `dotnet cli` instalado
Basta navegar até a página do projeto e digitar `dotnet run`

## Como usar?
Após o `dotnet run` você digita qual pasta você quer limpar
* Ex: `dotnet run C:\Users\User\Documents\Codes\`
E após especifiar a pasta, basta especificar os padrões que você quer que sejam excluídos
* Ex: `dotnet run C:\Users\User\Documents\Codes\ node_modules` Vai excluir todas as pastas `node_modules`
* Ex2: `dotnet run C:\Users\User\Documents\Codes\ node_modules *.exe` vai excluir todas as pastas `node_modules` e todos os arquivos *.exe
## 
(Talvez num futuro eu adicione uma forma de especificar exceções)