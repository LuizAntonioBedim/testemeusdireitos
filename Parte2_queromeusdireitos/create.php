<!DOCTYPE html>
<html>
<head>
    <title>Adicionar Novo Livro</title>
</head>
<body>
    <div>
    <h1>Adicionar Novo Livro</h1>
</div>
<span>
    <form action="insert.php" method="post">
        <label>Titulo:</label>
        <input type="text" name="titulo" required>

        <label>Autor:</label>
        <input type="text" name="autor" required>

        <label>Ano de publicação</label>
        <input type="number" name="ano_public" required>

        <input type="submit" value="Salvar" id="save">
    </form>
</span>
    <?php require_once ('createcss.php');?>
</body>
</html>