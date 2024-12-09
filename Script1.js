// Adicionar um evento ao formulário para capturar o envio
document.getElementById("consultaForm").addEventListener("submit", function (event) {
    event.preventDefault(); // Impede o recarregamento da página ao enviar o formulário

    // Captura os valores do formulário
    const criterio = document.getElementById("criterio").value;
    const valor = document.getElementById("valor").value;

    // Monta a URL para a requisição ao backend
    const url = `https://localhost:5001/api/livros/consulta?criterio=${criterio}&valor=${encodeURIComponent(valor)}`;

    // Envia a requisição ao backend usando fetch
    fetch(url)
        .then((response) => {
            if (!response.ok) {
                throw new Error("Erro ao consultar livros: " + response.statusText);
            }
            return response.json(); // Converte a resposta para JSON
        })
        .then((data) => {
            // Exibe os resultados retornados do backend
            const resultado = document.getElementById("resultado");
            resultado.innerHTML = ""; // Limpa resultados anteriores
            data.forEach((livro) => {
                const item = document.createElement("li");
                item.textContent = `Título: ${livro.titulo}, Autor: ${livro.autor}, Assunto: ${livro.assunto}`;
                resultado.appendChild(item);
            });
        })
        .catch((error) => {
            console.error("Erro:", error);
            alert("Ocorreu um erro ao consultar os livros.");
        });
});
