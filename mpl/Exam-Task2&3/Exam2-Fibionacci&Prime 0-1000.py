def is_prime(n):
    if n < 2:
        return False
    for i in range(2, int(n ** 0.5) + 1):
        if n % i == 0:
            return False
    return True


def fibonacci_numbers(limit):
    fibs = []
    a, b = 0, 1
    while b < limit:
        fibs.append(b)
        a, b = b, a + b
    return fibs


def count_prime_fibonacci(limit):
    fibs = fibonacci_numbers(limit)
    count = 0
    for num in fibs:
        if is_prime(num):
            count += 1
    return count


result = count_prime_fibonacci(1000)
print("Count of numbers that are both Fibonacci and prime:", result)
