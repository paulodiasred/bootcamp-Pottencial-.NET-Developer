** Vi em um repositorio e achei a ideia interessante, acabei criando no meu repositório também
para facilitar meus estudos e futuros trabalhos.

Comandos básicos do Git vistos em aulas.

git commit -m"conteudo da mensagem de commit": Gravação de arquivo no git. Esse comando serve para commitar os arquivos no git.
O "-m" é referete ao termo "message". Mensagem que será gravada no commit.

ctrl + l = Limpa a tela do terminal do git.

git log: Visualizar os logs dos arquivos gravados no repositório. 

git remote add origin + endereço da pasta no github: Permite apontar para o repositório no github.
Ou seja, o usuário cria uma página no github e pode direcionar uma página do seu computador local para a pasta do github sem
precisar clonar o repositório.

git clone + endereço da pasta no github:  Serve para clonar um projeto no github.

gitignore: Arquivo para ser criado no git e evitar que determinados arquivos sejam adicionaos.
O git irá ignorar os arquivos que estuverem dentro dele. 

Exemplo: touch .gitignore (Criar arquivo dentro da pasta desterminada)
echo "nome do arquivo que vc quer ignorar" >> .gitignore (Escreve dentro do arquivo do gitignore o nome do arquivo que 
você quer ignorar.).

git add .gitignore: Adicionando o gitignore dentro do githubIgnorando todos os arquivos de uma extenção: 
echo "*.log" >> .gitignore

Ignorar um diretório inteiro:
echo "pastaignorada/" >> .gitignore

git commit -am"Rastreando/adicionando e commitando ao mesmo tempo um arquivo."

git log -n 3: Mostra os três últimos commits.

git log --oneline: Resumo dos commits feitos no projeto.

git log --state: Mostra o resumo dos arquivos alterados com o número de linhas alteradas e removidas.

git rm nomedoarquivo: Remove/deleta um arquivo do repositório. Todo arquivo removido precisa ser
commitado - Não esquecer disso.

git mv nomeantigo nome_novo: O comando "mv" altera o nome de um arquivo. Renomeia o arquivo existente, exemplo:

  git mv algo01.py algoritmo01.py

git checkout -- nomedoarquivo: Permite desfazer uma alteração em um determinado arquivo, exemplo:

  echo "Mudança no arquivo!" >> arquivo.txt -> Efetuando mudança no arquivo.

git checkout -- arquivo.txt: Cancelando a última alteração do arquivo. Lembrando, as alterações só podem ser refeitas
se estiverem fora do stage. Ou seja, antes de adicionar o arquivo com o comando -> git add nomedoarquivo.

git reset --hard: Desfaz todas as modificações que você fez.

git branch novo_branch: Cria um novo branch.

git branch: Lista as branchs existentes.

git checkout novo_branch: Muda de branch.

git checkout -b nova_branch: Cria uma nova branch e troca para ela ao mesmo tempo.

git branch -d nova_branch: Deleta um branch criada.

OBS: Uma branch só pode ser deletada se o usuário não estiver nela. O desenvolvedor deve mudar de branch com o comando "git checkout master" (por exemplo) e deletar a branch que deseja.

git branch -D nova_branch: O comando usando o "-D" (letra maiúscula) é usado quando existe commit na branch.

git branch --no-merged: Identifica se existe alguma branch não mesclada.

git merge nova_branch -m"Mensagem sobre a mesclagem da branch.": Mescla a nova_branch ao master.