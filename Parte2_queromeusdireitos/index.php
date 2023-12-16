<!DOCTYPE html>
<html>
<head>
    <title>SEGUNDA PARTE TESTE</title>
    
</head>
<body>
    <div>
<h1 id="title">Livraria Criativa</h1>
    <a href="create.php" id="add">Adiconar</a>
    <h1 id="livros">LIVROS</h1>
</div>
    <?php
    require ('connec.php');
    require_once ('main.php');
    
    function listarLivros($pdo) {
        $sql = "SELECT * FROM LIVROS";
        $stmt = $pdo->query($sql);
        return $stmt->fetchAll(PDO::FETCH_ASSOC);
    }

    $registros = listarLivros($pdo);
    
    echo "<span><table>
        <tr>
            <th>ID</th>
            <th>Título</th>
            <th>Autor</th>
            <th id='ano'>Ano</th>
        </tr>";
        foreach ($registros as $registro)
        {
            echo "<tr>";
            echo "<td>" . $registro['id'] . "</td>";
            echo "<td>" . $registro['titulo'] . "</td>";
            echo "<td>" . $registro['autor'] . "</td>";
            echo "<td>" . $registro['ano_public'] . "</td>";
            echo "<td>
                <a href='edit.php?id=" . $registro['id'] . "'>Editar</a>
                <a href='delete.php?id=" . $registro['id'] . "'>Excluir</a>
                </td>";
        }
            echo "</tr>";
            echo "</table></span>";
    ?>
    <footer>Feito por Luiz Antonio Bedim Neto</footer>
</body>
</html>