# Lab24 – Strategy and Observer Patterns (C#)

## Мета роботи
Реалізувати систему обробки числових даних з використанням патернів Strategy та Observer.

## Strategy
Реалізовано інтерфейс INumericOperationStrategy та його реалізації:

- SquareOperationStrategy – квадрат числа
- CubeOperationStrategy – куб числа
- SquareRootOperationStrategy – квадратний корінь

Клас NumericProcessor використовує стратегію і може змінювати її під час виконання.

## Observer
Реалізовано:

Subject:
- ResultPublisher – генерує подію ResultCalculated

Observers:
- ConsoleLoggerObserver – вивід у консоль
- HistoryLoggerObserver – збереження історії
- ThresholdNotifierObserver – повідомлення при перевищенні порогу

## Робота програми

Програма:

- змінює стратегії
- обробляє числа
- повідомляє observers
- зберігає історію

## Висновок

Було успішно реалізовано патерни Strategy та Observer у C#.
