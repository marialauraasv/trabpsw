// URLs da API
const usuariosUrl = '/api/usuarios';
const emprestimosUrl = '/api/emprestimos';

// Preencher tabela de usuários
fetch(usuariosUrl)
    .then(response => response.json())
    .then(data => {
        const tableBody = document.querySelector('#usuarios-table tbody');
        data.forEach(usuario => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${usuario.nome}</td>
                <td>${usuario.perfil}</td>
            `;
            tableBody.appendChild(row);
        });
    });

// Preencher tabela de empréstimos
fetch(emprestimosUrl)
    .then(response => response.json())
    .then(data => {
        const tableBody = document.querySelector('#emprestimos-table tbody');
        data.forEach(emprestimo => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${emprestimo.livro}</td>
                <td>${emprestimo.usuario}</td>
                <td>${emprestimo.dataEmprestimo}</td>
                <td>${emprestimo.dataDevolucao}</td>
            `;
            tableBody.appendChild(row);
        });
    });

