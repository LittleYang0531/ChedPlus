# ChedPlus

[Ched](https://github.com/4yn/Ched) designed for World Dai Star(Stellarity). Respect [@paralleltree](https://twitter.com/paralleltree) and [@4yn](https://github.com/4yn). Download [here](https://github.com/LittleYang0531/ChedPlus/releases)

- Added Split Line Event

# Original ChedPlus Readme

[Ched](https://github.com/paralleltree/Ched) with extra features. Respect [@paralleltree](https://twitter.com/paralleltree). Download [here](https://github.com/4yn/Ched/releases).

- Disabled double right click toggle between edit and select mode
- Right click in edit mode behaves like erase
- Middle click in edit mode behaves like select
- Added hotkeys (Preview using [keyboard layout editor](http://www.keyboard-layout-editor.com/))

  ![hotkeys](./resources/keyboard-layout.png)

- Added playfield autoscroll when previewing
- Changed tick sound to ksm tick sound
- Increased note thickness
- Prevent air-action notes from overlapping other notes

  ![note thickness](./resources/note-thickness.png)

- Pre-included .sus import from [sus2img](https://github.com/paralleltree/sus2img)
- Added bezier curve note with gray color

  ![beizers](./resources/beizers.png)

  - Import/export with .sus works
  - Use at most 1 curve between every 2 slide steps
  - If two "SLIDE CURVE" notes are next to each other, the later one will default to a "SLIDE STEP" note with black color and .sus export will also automatically convert to "SLIDE STEP"

  ![duplicate curve](./resources/duplicate-curve.png)

- Added scroll up/down shortcut buttons
- Updated to latest upstream features as of [Ched 3.1.0](https://github.com/paralleltree/Ched/releases/tag/v3.1.0.0)
  - Shortcut editor
  - Export hotkey (Ctrl + E)
- Made sus export distinct from upstream Ched
- Added file association, double clicking on .chs files will open the editor
- Added 'Play at half speed' option in play menu
- Switched to ManagedBass audio library
- Implemented ExTap notes with downwards and central flourishes + import/export function

  ![extap](./resources/extap.png)

- Pulled chinese translation from [kami-poi's fork](https://github.com/kami-poi/Ched/commit/38838d692e495c722ac10a4492da311bec9c8010)
- Fix gradient bug of tap notes at large measure numbers (left is new, right is old)

  ![gradient bug](./resources/gradientbug.png)

- **Recorder!** Play something on your controller when previewing your chart and it will show up on the playfield. Make charting easier!

  ![recorder](./resources/recorder.gif)

  - Works with Yuancon, Tasoller (I-SAY-NYA-O and 2.0 firmware both work), [iPad/brokenithm-kb](https://github.com/4yn/brokenithm-kb/) (use the Yuancon keyboard option) or just use your keyboard (Tasoller keyboard option recommended)

  ![recorder options](./resources/recorder-options.png)

  - Remember to enable "Recoder (Add/Overwrite)" and select your input device in the options

# Original Readme

[![Build status](https://ci.appveyor.com/api/projects/status/pq1lght43m7ytlv1?svg=true)](https://ci.appveyor.com/project/paralleltree/ched)

某スライドしてヘドバンする音ゲーの譜面エディタ

既知のバグについては[Issues](https://github.com/paralleltree/Ched/issues)を参照してください。

## 機能とか

  * 時間軸ズーム
  * カスタム音符指定(1920分音符まで)
  * 再生プレビュー
  * 譜面保管所風プレビュー
  * BPM, ハイスピード, 拍子変更
  * [Sliding Universal Score(sus形式)](https://gist.github.com/kb10uy/c171c175ba913dc40a73c6ce69da9859)へのエクスポート

## ダウンロード

現在の最新版は[v3.1.0](https://github.com/paralleltree/Ched/releases)です。

## 使い方

[Wiki](https://github.com/paralleltree/Ched/wiki)を参照してください。

## スクリーンショット

![preview](https://user-images.githubusercontent.com/7324519/36943885-93922e32-1fd4-11e8-9042-688d36288a03.png)

## フィードバックについて
バグ報告などは[@paralleltree](https://twitter.com/paralleltree)までお願いします。

## ライセンス
ChedはMITライセンスです。

その他利用しているライブラリは次の通りです。

### System.Reactive
> Copyright (c) .NET Foundation and Contributors All Rights Reserved  
Licensed under the Apache License, Version 2.0 (the "License");  
you may not use this file except in compliance with the License.  
You may obtain a copy of the License at  
http://www.apache.org/licenses/LICENSE-2.0  
Unless required by applicable law or agreed to in writing, software  
distributed under the License is distributed on an "AS IS" BASIS,  
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or  
implied. See the License for the specific language governing permissions  
and limitations under the License.

### Newtonsoft.Json
> The MIT License (MIT)  
Copyright (c) 2007 James Newton-King  
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:  
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.  
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### Fugue Icons
> Icons by Yusuke Kamiyamane. Licensed under a Creative Commons Attribution 3.0 License.

### ConcurrentPriorityQueue
> The MIT License (MIT)  
Copyright (c) 2015 Denis Shulepov  
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:  
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.  
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### Bass Audio Library
> BASS is free for non-commercial use. If you are a non-commercial entity
(eg. an individual) and you are not making any money from your product
(through sales/advertising/etc), then you can use BASS in it for free.
If you wish to use BASS in commercial products, then please also see the
next section.  
TO THE MAXIMUM EXTENT PERMITTED BY APPLICABLE LAW, BASS IS PROVIDED
"AS IS", WITHOUT WARRANTY OF ANY KIND, EITHER EXPRESSED OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY
AND/OR FITNESS FOR A PARTICULAR PURPOSE. THE AUTHORS SHALL NOT BE HELD
LIABLE FOR ANY DAMAGE THAT MAY RESULT FROM THE USE OF BASS. YOU USE
BASS ENTIRELY AT YOUR OWN RISK.  
Usage of BASS indicates that you agree to the above conditions.  
All trademarks and other registered names contained in the BASS  
package are the property of their respective owners.

### XAML Behaviors

> The MIT License (MIT)  
Copyright (c) 2015 Microsoft  
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:  
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.  
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

## Special Thanks
  * [@kb10uy](https://twitter.com/kb10uy)
  * [@Horeizai_YMK](https://twitter.com/Horeizai_YMK)
  * [@Citringo](https://github.com/Citringo)
  * [@aripen1231](https://twitter.com/aripen1231)
  * [@ORIent_8](https://twitter.com/ORIent_8)
  * [@masa_otoge](https://twitter.com/masa_otoge)
  * [@CobaBlu_0510](https://twitter.com/CobaBlu_0510)
