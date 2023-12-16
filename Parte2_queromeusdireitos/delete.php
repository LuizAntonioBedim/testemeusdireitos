<?php
    require ('connec.php');
    require ('sucess.php');

if ($_SERVER["REQUEST_METHOD"] == "GET") {
    $id = $_GET["id"];

    // Função para deletar o registro no banco de dados
    function excluirRegistro($pdo, $id) {
        $sql = "DELETE FROM livros WHERE id = $id";
        $stmt = $pdo->prepare($sql);
        return $stmt->execute();
    }
}
if (excluirRegistro($pdo, $id)) {
    echo "<div>Registro excluído com sucesso!</div>" . "<div><a href='index.php'>HOME</a></div>";
} else {
    echo 'Erro ao excluir o registro.';
}
?>