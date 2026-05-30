<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" height="160" />

# Game Frame X LitJson

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/releases)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

[文檔](https://gameframex.doc.alianblank.com) | [快速開始](https://gameframex.doc.alianblank.com) | [QQ群](https://qm.qq.com/q/urKenB9AU)

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## 項目簡介

適用於 Unity 的改進型 LitJson 庫，基於 [XINCGer/LitJson4Unity](https://github.com/XINCGer/LitJson4Unity) 二次包裝。

該庫主要服務於 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作為子庫使用。

## 快速開始

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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
  ]
}
```

然後在 `dependencies` 中添加此套件：

```json
{
  "dependencies": {
    "com.gameframex.unity.xincger.litjson": "1.1.1"
  }
}
```

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

## 改動功能

1. 新增 `link.xml` 的裁剪過濾
2. 新增 `LitJsonCroppingHelper` 防裁剪腳本

## 特性

基於[原生的 LitJson 庫](https://github.com/LitJSON/litjson)改造，支援以下原生版本不支援的特性：

- 支援 float 類型
- 支援 Unity 內建類型（Vector2、Vector3、Rect、AnimationCurve、Bounds、Color、Color32、Quaternion、RectOffset 等）
- 支援 JsonIgnore Attribute，對某些欄位跳過序列化
- 支援對輸出的 Json 內容格式化，更規整
