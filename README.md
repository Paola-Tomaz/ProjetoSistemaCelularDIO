# Desafio de Projeto: Sistema de Celulares

Este repositório contém a implementação do desafio de projeto proposto pela DIO (Digital Innovation One) na trilha .NET, no módulo de **Programação Orientada a Objetos**. O objetivo do projeto é criar uma abstração de um sistema que trabalha com celulares, usando conceitos de orientação a objetos.

📱 **Contexto**

Você foi contratado para modelar um sistema que gerencia celulares de diferentes marcas. O sistema utiliza uma classe abstrata para representar um celular genérico e classes específicas para marcas como Nokia e iPhone, onde cada marca tem seu próprio comportamento.

O desafio consiste em implementar a abstração de um celular e permitir que as classes filhas (Nokia e iPhone) sobrescrevam o comportamento de instalação de aplicativos de maneira distinta.

### **Diagrama de Classes**

```plaintext
                +------------------------+
                |      Smartphone        |
                |------------------------|
                | - Modelo: string       |
                | - Marca: string        |
                |------------------------|
                | + Ligar()              |
                | + Desligar()           |
                | + InstalarAplicativo() |
                +------------------------+
                    ^               ^
                   /                 \
+------------------------+       +-------------------------+
|         Nokia          |       |         Iphone          |
|------------------------|       |-------------------------|
| + InstalarAplicativo() |       |  + InstalarAplicativo() |
+------------------------+       +-------------------------+
```

## ✨ Proposta

Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para os celulares Nokia e iPhone.

### **Regras e validações**

- A classe `Smartphone` deve ser abstrata, não podendo ser instanciada, servindo apenas como modelo para outras classes.

- As classes `Nokia` e `Iphone` devem herdar de `Smartphone` e implementar o método `InstalarAplicativo()` de maneira distinta para cada tipo de celular.

- O método `InstalarAplicativo()` deve ser sobrescrito nas classes `Nokia` e `Iphone`, pois cada marca tem sua própria forma de instalar aplicativos.

🔧 **Solução**

O código está parcialmente implementado, e você deve continuar a implementação, seguindo as regras descritas acima. Procure pela palavra comentada `TODO` no código e implemente as funcionalidades conforme solicitado.

## ✅ Requisitos

- A classe `Smartphone` será a classe base abstrata.

- As classes `Nokia` e `Iphone` devem herdar de `Smartphone` e implementar o método `InstalarAplicativo()` de forma personalizada.

- O código do programa está parcialmente implementado, e você precisará completar as funcionalidades para que o sistema funcione corretamente.

## 💻 Tecnologias Utilizadas

- Linguagem: C#
- Framework: .NET

## 🚀 Como Executar

1. **Clone o repositório:**

```bash
 git clone https://github.com/Paola-Tomaz/ProjetoSistemaCelularDIO.git
```

2. **Navegue até o diretório do projeto:**


```bash
 cd ProjetoSistemaCelularDIO
```

3. **Compile e execute o projeto:**

```bash
 dotnet run
``` 

## 📂 Estrutura do Projeto

```plaintext
📁 ProjetoSistemaCelularDIO
├── 📂 Models
│   ├── Smartphone.cs
│   ├── Nokia.cs
│   └── Iphone.cs
├── Program.cs
├── DesafioPOO.csproj
```

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

---

Desenvolvido por [Paola](https://github.com/Paola-Tomaz) durante a trilha .NET da DIO.
