## Animation library for Xamarin

Add awesome animations to Xamarin Native apps

![](https://github.com/brainoffline/XAnimations/blob/master/XAnimations.gif?raw=true)

### Setup
* Available on NuGet: http://www.nuget.org/packages/XAnimations
* Install into your Xamarin Native project.

**Platform Support**

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Soon||
|Xamarin.Android|Yes|API 19+|
|Windows 10 UWP|Soon||
|Xamarin.Mac|Soon||


### API Usage


**Start**

Begin playing an animation

```csharp
titleView.CreateAnimator<BounceInAnimator>().Start();
```

**Animate**

Wait for an animation to finish before continuing processing.

```csharp
await titleView.CreateAnimator<BounceInAnimator>().Animate();
```

### Other Stuff

#### Inspiration
[Android View Animations](https://github.com/daimajia/AndroidViewAnimations) by [daimajia](https://github.com/daimajia)

[easings.net](http://easings.net/)


#### Contributions
Contributions are welcome! If you find a bug please report it and if you want a feature please report it.

If you want to contribute code please file an issue and create a branch off of the current dev branch and file a pull request.

#### License
Under MIT, see LICENSE file.
