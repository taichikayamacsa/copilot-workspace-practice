# copilot-workspace-practice

コンソールで動作する、シンプルな C# 電卓アプリです。

## プロジェクト構成

- `CalculatorApp/Program.cs`: 電卓ロジック本体
- `CalculatorApp/CalculatorApp.csproj`: .NET プロジェクト定義

## できること

- 2つの数値を入力
- 演算子 `+`, `-`, `*`, `/` を入力
- 計算結果を表示

## 実行方法

リポジトリ直下で次のコマンドを実行します。

```bash
dotnet run --project CalculatorApp/CalculatorApp.csproj
```

## 入力ルールとエラー

- 数値として解釈できない入力の場合は `🙅` を表示して終了します
- 演算子が `+`, `-`, `*`, `/` 以外の場合は `無効な演算子です` を表示します
- 0除算（`/` で2つ目の値が 0）の場合は `0で割ることはできません` を表示します