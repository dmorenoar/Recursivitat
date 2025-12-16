# Recursivitat en C#

Aquest projecte conté exemples educatius sobre **recursivitat** en C#, comparant implementacions iteratives i recursives, i explicant el concepte de forma detallada.

## Contingut

El programa inclou els següents exemples:

1. **SumaIt** - Suma iterativa de nombres de l'1 al n
2. **SumaRec** - Suma recursiva de nombres de l'1 al n
3. **CompteEnrere** - Compte enrere amb recursió
4. **ComptaDigits** - Compta els dígits d'un nombre

## Conceptes de Recursivitat

### Què és una funció recursiva?

Una funció recursiva és aquella que:
- **Es crida a si mateixa**
- **Té un cas base** que atura les crides (evita recursió infinita)

### Fases de la Recursió

#### Fase de Baixada (Crides)
Les crides recursives s'apilen sense executar-se completament fins arribar al cas base.

#### Fase de Pujada (Retorns)
Un cop assolit el cas base, es resolen les operacions pendents i es retornen els valors.

## Exemples Detallats

### 1. Suma de Nombres (SumaRec)

Calcula la suma de nombres de l'1 al n de forma recursiva.

```csharp
SumaRec(4) → 4 + 3 + 2 + 1 + 0 = 10
```

**Fase de baixada:**
```
SumaRec(4) = 4 + SumaRec(3)
SumaRec(3) = 3 + SumaRec(2)
SumaRec(2) = 2 + SumaRec(1)
SumaRec(1) = 1 + SumaRec(0)
SumaRec(0) = 0  ← cas base
```

**Fase de pujada:**
```
SumaRec(0) = 0
SumaRec(1) = 1 + 0 = 1
SumaRec(2) = 2 + 1 = 3
SumaRec(3) = 3 + 3 = 6
SumaRec(4) = 4 + 6 = 10
```

### 2. Compte Enrere (CompteEnrere)

Imprimeix nombres en ordre ascendent utilitzant recursió.

```csharp
CompteEnrere(3) → Imprimeix: 1, 2, 3
```

**Important:** 
- El codi abans de la crida recursiva s'executa a la **fase de baixada**
- El codi després de la crida recursiva s'executa a la **fase de pujada**

### 3. Comptar Dígits (ComptaDigits)

Compta quants dígits té un nombre.

```csharp
ComptaDigits(4321) → 4 dígits
```

**Procés:**
```
ComptaDigits(4321) = 1 + ComptaDigits(432)
ComptaDigits(432) = 1 + ComptaDigits(43)
ComptaDigits(43) = 1 + ComptaDigits(4)
ComptaDigits(4) = 1  ← cas base (< 10)
```

## Plantilla Universal per a Recursió

```csharp
public static TipusRetorn FuncioRecursiva(parametres)
{
    // 1. Cas base (condició d'aturada)
    if (casBase) return valorBase;
    
    // 2. Cas recursiu (problema més petit)
    return pasActual + FuncioRecursiva(problemaMesPetit);
}
```

## Passos per Crear una Funció Recursiva

1. **Decidir què ha de fer la funció**
2. **Trobar el cas base** - Condició per aturar les crides
3. **Definir el pas actual** - Com es redueix el problema
4. **Implementar el cas recursiu** - Cridar la funció amb un problema més petit

## Execució del Programa

En executar el programa s'obtindrà:

```
10
10
...
...
...
...
...
...
...
...
...
...
1
2
3
4
5
6
7
8
9
10
```
