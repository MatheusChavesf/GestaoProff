Feature: Gerenciar Curso

  Scenario: Adicionar Curso
    Given o usuário está na página de adição de cursos
    When o usuário preenche o formulário corretamente
    And clica no botão "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
