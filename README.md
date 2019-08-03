# ladder-edit

    Classe LDEdit
    ====================================
    
    Implementa um editor ladder abstrato.
    
    No intuito de criar um editor independente de plataforma e biblioteca gráfica,
    a classe LDEDit foi criada para juntar todos os comportamentos básicos de um editor
    `LADDER`. A classe LDEdit proporciona um baixo acoplamento e uma alta coesão em relação
    à biblioteca gráfica escolhida para a implementação da interface com o usuário.
    
    A interface gráfica terá que conduzir o comportamento externo vindo do usuário para o objeto
    instanciado da classe LDEdit para que ele possa acessar diretamente os outros objetos que compõem todo
    o editor `LADDER`.
    
                        +-----------+
        +---------+     | interface |        +-------------+
        | usuário |     | gráfica   |        |editor:LDEdit|
        +---------+     +-----------+        +-------------+
             |   event        |                     |
             |-------------> +-+  do_event(params)  |
             |               | |-----------------> +-+
             |               | |                   | |
             |               | |                   | |
             |               | |                   | |
             |               | |                   +-+
             |               +-+                    |
             |                |                     |
          
     Diagrama 1 - Condução de um evento do usuário para o editor através da interface gráfica.
    
    A comunicação no sentido instância de LDEdit para a interface gráfica será feita através de
    eventos que devem ser previamente declarados utilizando o método `connect(event,callback)`.
