def sum_of_digits(num):
    # פונקציה שמחשבת את סכום הספרות של מספר
    return sum(int(digit) for digit in str(num))

def main():
    for i in range(1, 1001):
        if i % sum_of_digits(i) == 0:
            print(f"[i] is a perfect number")

if __name__ == "__main__":
    main()
