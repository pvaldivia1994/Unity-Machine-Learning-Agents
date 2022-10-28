# Proyect Unity Machine Learning Agents

Este proyecto usa Unity ML Agents para aportar librerías y conceptos de aprendizaje básicos sobre un NPC en un entorno aleatorio.
Para el uso del mismo es necesario:

Descargar los paquetes del asset store:
- Starter Assets - Third Person Character Controller 1.1.1
- POLYGON Dungeons - Low Poly 3D Art by Synty 1.6
- POLYGON Starter Pack - Low Poly 3D Art by Synty 1.0

Tener instalado:
- [Anaconda](https://www.anaconda.com/). la versión utilizada en el proyecto es Anaconda3 2022.10.
- Python 3.7

**CMD** Primeros Comandos:
- conda env list
- conda activate [def env name]
- conda create -n unity-ml-04 python=3.7
- conda activate unity-ml-04
- pip install mlagents==0.17

Descargar el archivo basic.yaml de la carpeta ML_Brain y en la ruta del mismo ejecutar el siguiente comando:

- mlagents-learn ./basic.yaml --run-id npc01
- Esperar que la consola diga que debe darle a play en Unity 
- Darle a play en Unity
- Despues de que entrene para ver los resultados ejecutar el comando: tensorboard --logdir results

