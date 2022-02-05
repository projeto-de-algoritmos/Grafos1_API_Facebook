# Criação de arquivos bases com matplotlib.pyplot para manipulação de grafos
import networkx as nx
import matplotlib.pyplot as plt

#Criação de um grafo vazio 
G = nx.Graph()

# Adicionando vértices
G.add_node('v1')
G.add_node('v2')
G.add_node('v3')
G.add_node('v4')
G.add_node('v5')

# Adicionando Arestas
G.add_edge('v1', 'v2')
G.add_edge('v2', 'v3')
G.add_edge('v3', 'v4')
G.add_edge('v4', 'v5')
G.add_edge('v5', 'v1')
G.add_edge('v2', 'v4')

# Lista os vértices

print('Lista de vértices')
print(G.nodes())
input()

# Percorre o conjunto de vértices
print('Percorrendo os vértices')
for v in G.nodes():
  print(v)
input()

# Lista de arestas
print('Lista de arestas')
print(G.edges())
input()

# Percorre o conjunto de arestas
print('Percorrendo as arestas')
for e in G.edges():
  print(e)
input()

# Mostra a lista de graus
print('Lista de graus de G')
print(G.degree())
input()

# Acessa o grau do vértice v2
print('O grau do vértice v2 é %d' %G.degree()['v2'])
print()

#Grafo como lista de adjacências
print('Grafo como lista de adjacências')
print(G['v1'])
print(G['v2'])
print(G['v3'])
print(G['v4'])
print(G['v5'])
input()

# Obtém a matriz de adjacências do grafo G
print('Matriz de adjacências de G')
A = nx.adjacency_matrix(G) #retorna uma matriz esparsa para economizar memoria
print(A.todense()) # converte para matriz densa (padrão)

# Adiciona um campo peso em cada aresta do grafo
G['v1']['v2']['peso'] = 5
G['v2']['v3']['peso'] = 10
G['v3']['v4']['peso'] = 2
G['v4']['v5']['peso'] = 7
G['v5']['v1']['peso'] = 4
G['v2']['v4']['peso'] = 8

# Lista cada aresta e seus respectivos pesos
print('Adicionando pesos as aresta')
for edge in G.edges():
  u = edge[0]
  v = edge[1]
  print('0 peso da aresta', edge, 'vale', G[u][v]['peso'])
input()
print()

print('Plotando o grafo como image...')

plt.figure(2)
# Há vários layouts, mas spring é um dos mais bonitos
nx.draw_networkx(G, pos=nx.spring_layout(G), with_labels=True)
plt.show()
