## Um app de limpeza de pastas batizado provisoriamente de `Talpidae`
Um programa simpleszinho que eu uso para excluir alguns arquivos antes de fazer o backup dos meus projetos, geralmente excluo pastas/arquivos como `node_modules`, arquivos `.exe`, etc.

## Como usar?
Digite ```dotnet run``` e após a pasta que quer ser limpa
 ```bash
dotnet run C:\Users\User\Documents\Codes\
```
após especifiar a pasta que deve ser limpa, especifique os padrões de pastas ou arquivos que você quer que sejam excluídos
```bash
dotnet run C:\Users\User\Documents\Codes\ node_modules
``` 
Vai excluir todas as pastas `node_modules`
```bash
dotnet run C:\Users\User\Documents\Codes\ node_modules *.exe ...
```
vai excluir todas as pastas `node_modules` e todos os arquivos `.exe` e se quiser, mais padrões
## 
(Talvez num futuro eu adicione uma forma de especificar exceções)