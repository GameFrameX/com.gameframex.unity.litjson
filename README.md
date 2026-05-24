<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" height="160" />

# Game Frame X LitJson

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.xincger.litjson)](https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson/releases)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

[Documentation](https://gameframex.doc.alianblank.com) | [Quick Start](https://gameframex.doc.alianblank.com) | [QQ Group](https://qm.qq.com/q/urKenB9AU)

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Project Overview

An improved LitJson library for Unity, repackaged from [XINCGer/LitJson4Unity](https://github.com/XINCGer/LitJson4Unity).

This library serves as a sub-module for [GameFrameX](https://github.com/AlianBlank/GameFrameX).

## Installation (choose one)

1. Add to `manifest.json`:
   ```json
   {"com.gameframex.unity.xincger.litjson": "https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson.git"}
   ```
2. Add via Unity Package Manager using Git URL:
   https://github.com/GameFrameX/com.gameframex.unity.xincger.litjson.git
3. Download the repository and place it in your Unity project's `Packages` directory

## Modifications

1. Added `link.xml` for stripping filter
2. Added `LitJsonCroppingHelper` anti-stripping script

## Features

Based on the [original LitJson library](https://github.com/LitJSON/litjson), with additional features not supported in the original:

- Support for float type
- Support for Unity built-in types (Vector2, Vector3, Rect, AnimationCurve, Bounds, Color, Color32, Quaternion, RectOffset, etc.)
- Support for JsonIgnore Attribute to skip serialization of certain fields
- Support for formatted JSON output
