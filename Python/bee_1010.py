codigo1, numerodepecas1,valorunitario1 = input().split()
codigo2, numerodepecas2, valorunitario2 = input().split()

valor1 = int(numerodepecas1) * float(valorunitario1)
valor2 = int(numerodepecas2) * float(valorunitario2)          


print(f"VALOR A PAGAR: R$ {valor1 + valor2:.2f}")

