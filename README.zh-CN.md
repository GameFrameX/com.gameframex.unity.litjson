<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# Game Frame X LitJson

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#quick-start) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## 项目简介

适用于 Unity 的改进型 LitJson 库，基于 [XINCGer/LitJson4Unity](https://github.com/XINCGer/LitJson4Unity) 二次包装。

该库主要服务于 [GameFrameX](https://github.com/AlianBlank/GameFrameX) 作为子库使用。

## 快速开始

编辑 Unity 项目的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

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

然后在 `dependencies` 中添加此包：

```json
{
  "dependencies": {
    "com.gameframex.unity.xincger.litjson": "1.1.1"
  }
}
```

`scopes` 控制哪些包通过此注册表解析。只有以 `com.gameframex` 开头的包才会从这个注册表获取。

## 改动功能

1. 增加 `link.xml` 的裁剪过滤
2. 增加 `LitJsonCroppingHelper` 防裁剪脚本

## 特性

基于[原生的 LitJson 库](https://github.com/LitJSON/litjson)改造，支持以下原生版本不支持的特性：

- 支持 float 类型
- 支持 Unity 内建类型（Vector2、Vector3、Rect、AnimationCurve、Bounds、Color、Color32、Quaternion、RectOffset 等）
- 支持 JsonIgnore Attribute，对某些字段跳过序列化
- 支持对输出的 Json 内容格式化，更规整
