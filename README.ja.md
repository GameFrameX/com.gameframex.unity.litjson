<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X LitJson

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#quick-start) · QQグループ: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>

## プロジェクト概要

Unity 向けの改良版 LitJson ライブラリ。[XINCGer/LitJson4Unity](https://github.com/XINCGer/LitJson4Unity) をベースに再パッケージされています。

このライブラリは [GameFrameX](https://github.com/AlianBlank/GameFrameX) のサブモジュールとして機能します。

## クイックスタート

### インストール

以下のいずれかの方法を選択してください：

1. Unity プロジェクトの `Packages/manifest.json` を編集し、`scopedRegistries` セクションを追加してください：
   ```json
   {
     "scopedRegistries": [
       {
         "name": "GameFrameX",
         "url": "https://gameframex.upm.alianblank.uk",
         "scopes": [
           "com.gameframex"
         ]
       }
     ],
     "dependencies": {
       "com.gameframex.unity.xincger.litjson": "1.1.3"
     }
   }
   ```

   `scopes` は、どのパッケージをこのレジストリから解決するかを制御します。`com.gameframex` で始まるパッケージのみがこのレジストリから取得されます。

2. `manifest.json` の `dependencies` に直接追加：
   ```json
   {
      "com.gameframex.unity.xincger.litjson": "https://github.com/gameframex/com.gameframex.unity.xincger.litjson.git"
   }
   ```
3. Unity の **Package Manager** で **Git URL** を使用して追加：`https://github.com/gameframex/com.gameframex.unity.xincger.litjson.git`
4. リポジトリを Unity プロジェクトの `Packages` ディレクトリにクローンしてください。自動的に読み込まれます。

## 変更点

1. `link.xml` のストリッピングフィルターを追加
2. `LitJsonCroppingHelper` アンチストリッピングスクリプトを追加

## 特徴

[オリジナルの LitJson ライブラリ](https://github.com/LitJSON/litjson)をベースに、オリジナルではサポートされていない以下の機能を追加しています：

- float 型のサポート
- Unity 組み込み型のサポート（Vector2、Vector3、Rect、AnimationCurve、Bounds、Color、Color32、Quaternion、RectOffset など）
- JsonIgnore Attribute による特定フィールドのシリアライズスキップ
- JSON 出力のフォーマット対応
