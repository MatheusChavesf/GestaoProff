Feature: Gerenciar Nota

  Scenario: Adicionar Nota
    Given o usu�rio est� na p�gina de adi��o de notas
    When o usu�rio preenche o formul�rio corretamente
    And clica no bot�o "Adicionar"
    Then o sistema exibe uma mensagem de sucesso
