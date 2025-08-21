<img width="300px" src="https://avatars.githubusercontent.com/u/168340159?v=4" />

__CHANGELOG__

_All notable changes to this project will be documented in this file:_

# v 0.1.0  (2025-08-21)



---

## Bug Fixes

- change Name property access modifier to internal in Product class
  ([8e31172a](https://github.com/DaoChaShao/csharp-basic/commit/8e31172a989a85a65b5c9b89e69a10465686c754))


## Features

- implement main program to demonstrate Dependency Inversion Principle
  ([a28d6769](https://github.com/DaoChaShao/csharp-basic/commit/a28d6769c2dea9bf596ad0c40a8f5dc4b8be7fe6))
- add Book class to handle reservation notifications
  ([cca10924](https://github.com/DaoChaShao/csharp-basic/commit/cca109240d924ba8a83219783f103e77281c04db))
- add Sms notifier implementation for notification functionality
  ([43026550](https://github.com/DaoChaShao/csharp-basic/commit/43026550310ab4c6e53c9fd304c73cba9ffbf095))
- implement Email notifier for notification functionality
  ([710a589b](https://github.com/DaoChaShao/csharp-basic/commit/710a589bb9cf9d5b4f1e9dbd31d53be8212b64e7))
- add INotifier interface for notification functionality
  ([bac2b7ab](https://github.com/DaoChaShao/csharp-basic/commit/bac2b7ab6bd627f0c811df1e6acfac950973204d))
- add project file for Dependency Inversion Principle implementation
  ([943e61d7](https://github.com/DaoChaShao/csharp-basic/commit/943e61d756846bc7a08edc585a77497268a1f324))
- add Dependency Inversion Principle project to the solution
  ([e36d702b](https://github.com/DaoChaShao/csharp-basic/commit/e36d702b4131f6693bfe10d9736fd92c68eee653))
- add Program class to demonstrate usage of OldFashionedPrinter and MultiplePrinter
  ([81a74d12](https://github.com/DaoChaShao/csharp-basic/commit/81a74d129aaee6ebf258c2fffecb308668b9e82b))
- implement MultiplePrinter class with IPrint, IFax, ICopy, and IScan interfaces
  ([f2a49d51](https://github.com/DaoChaShao/csharp-basic/commit/f2a49d51ab0ed24105f721d863921f0c7a498c96))
- implement OldFashionedPrinter class with IPrint and IFax interfaces
  ([7e941a7e](https://github.com/DaoChaShao/csharp-basic/commit/7e941a7e0af915e081482bed64cb427f351c1df3))
- add IScan interface for scanning functionality
  ([4410ec57](https://github.com/DaoChaShao/csharp-basic/commit/4410ec57a801c0e1e04bcc51e40fc7124c89eb94))
- add IPrint interface for printing functionality
  ([f82fc9fc](https://github.com/DaoChaShao/csharp-basic/commit/f82fc9fc9339570ef2b5b69b8d357d6ea72e17d4))
- add IFax interface for faxing functionality
  ([be2a14cb](https://github.com/DaoChaShao/csharp-basic/commit/be2a14cbf9ccdf25d49a0078a3b893f65b2d054a))
- add ICopy interface for content copying functionality
  ([4c5382fd](https://github.com/DaoChaShao/csharp-basic/commit/4c5382fdec81ed45067e47911c0382deddc32992))
- add project file for Interface Segregation Principle implementation
  ([895a118d](https://github.com/DaoChaShao/csharp-basic/commit/895a118df52504e088804b5ebde4f15dd5872195))
- add Interface Segregation Principle project to solution
  ([7ddcce48](https://github.com/DaoChaShao/csharp-basic/commit/7ddcce483311f987e145a1d7227756af4c29a778))
- implement Main method to demonstrate Square class inheritance from Shape and Rectangle
  ([187332f8](https://github.com/DaoChaShao/csharp-basic/commit/187332f8945bffdaaa208587d3ba4d5bfd74fed8))
- add SquareFromShape class inheriting from Shape with overridden Area method
  ([51b811a1](https://github.com/DaoChaShao/csharp-basic/commit/51b811a19c58b496f4a65c440c5b4c56198d8e03))
- add SquareFromRectangle class inheriting from Rectangle with overridden Area method
  ([f8fc4418](https://github.com/DaoChaShao/csharp-basic/commit/f8fc4418c42008b7a87184a23f6e09943bb7a2d5))
- implement Rectangle class inheriting from Shape with Area method
  ([bd4f21bb](https://github.com/DaoChaShao/csharp-basic/commit/bd4f21bb0d8397a7d1ac369fb385bc250400fb16))
- add abstract Shape class with Area method for Liskov Substitution Principle
  ([389148d2](https://github.com/DaoChaShao/csharp-basic/commit/389148d29adf95cb6b0ac07057eb7dd660c8e58e))
- add initial project file for Liskov Substitution Principle example
  ([951eb344](https://github.com/DaoChaShao/csharp-basic/commit/951eb344fc6bbc88d8d5d0ab0b7be10f10ce7eaa))
- add Liskov Substitution Principle project to solution
  ([84551615](https://github.com/DaoChaShao/csharp-basic/commit/8455161527e6e557ac2f16ff943a78942b06420d))
- enhance filtering by adding combined specification for colour and size
  ([322d3d75](https://github.com/DaoChaShao/csharp-basic/commit/322d3d75a3e8edd118a9289e3a666c66cfb1f7b3))
- add SpecificationAnd class to combine multiple product specifications
  ([e2e24b2e](https://github.com/DaoChaShao/csharp-basic/commit/e2e24b2e41f16be86f9dcca931893a3c830756f7))
- add Program class to demonstrate product initialization and filtering by colour and size
  ([e2b7063a](https://github.com/DaoChaShao/csharp-basic/commit/e2b7063a08cfa643597129b46caadcd9b47fd565))
- add Product class to represent product details with name, colour, and size
  ([8c20e7f7](https://github.com/DaoChaShao/csharp-basic/commit/8c20e7f7b3307a6e5f47703490925f57a40d38e3))
- add Filter class for filtering products based on specifications
  ([43d164b6](https://github.com/DaoChaShao/csharp-basic/commit/43d164b636f68a78de1934a2e6a64403c8a5e0a7))
- add SpecificationSize class for size consistency evaluation
  ([7278b3e1](https://github.com/DaoChaShao/csharp-basic/commit/7278b3e14ddc2bfc57c7d4031ce5d62450552cb7))
- add SpecificationColour class for color consistency evaluation
  ([495b35a9](https://github.com/DaoChaShao/csharp-basic/commit/495b35a9c818a53d677609a43feaa8c92e8c05cc))
- add IAbstractFilter interface for filtering items based on specifications
  ([9b83b699](https://github.com/DaoChaShao/csharp-basic/commit/9b83b699ed28688914718ec9032aeb55929e1b86))
- add ISpecification interface for consistency evaluation in Open/Closed Principle project
  ([4d3d6e6c](https://github.com/DaoChaShao/csharp-basic/commit/4d3d6e6ceb5ca5cad1b5c5c34b2cb04a72ff679f))
- add Size enum for size representation in Open/Closed Principle project
  ([83c767d0](https://github.com/DaoChaShao/csharp-basic/commit/83c767d0308aed87651fa48c483a907152039198))
- add Colour enum for color representation in Open/Closed Principle project
  ([3738472c](https://github.com/DaoChaShao/csharp-basic/commit/3738472c1f4e37b517b2f9aca75f74068e76c47f))
- add project file for Open/Closed Principle implementation
  ([fc2ce42c](https://github.com/DaoChaShao/csharp-basic/commit/fc2ce42c156a271490e270b76dedc42dd3e9056c))
- add Open/Closed Principle project to solution
  ([26eb6d5d](https://github.com/DaoChaShao/csharp-basic/commit/26eb6d5d91d6ff4f3a41b45119a1763d374976ac))
- implement journal recording and persistence in Main method
  ([34185777](https://github.com/DaoChaShao/csharp-basic/commit/3418577714a9a21e81a000d5f514f9099cf0fb0f))
- add StorageManager class for saving and loading journal entries as text files
  ([dce24f70](https://github.com/DaoChaShao/csharp-basic/commit/dce24f7034694cfe18016b28ec007b0f2977203d))
- add Journal class to manage diary records with timestamping
  ([e2c8c893](https://github.com/DaoChaShao/csharp-basic/commit/e2c8c8936287449237ef090c6b18265db5b9aecf))
- add template file for commit messages
  ([107eccb7](https://github.com/DaoChaShao/csharp-basic/commit/107eccb7cb4beaf017f5c925453cd69fbcd55664))
- add commit template file
  ([8e76a498](https://github.com/DaoChaShao/csharp-basic/commit/8e76a49890438788a4422bfa8e9ddf3540b0cfce))


## Documentation

- update Chinese README with privacy statement and usage instructions
  ([56d39792](https://github.com/DaoChaShao/csharp-basic/commit/56d39792df934c602e35b22f0bb6650d773aba60))
- add Chinese README with privacy notice, license information, and usage instructions
  ([491f80a1](https://github.com/DaoChaShao/csharp-basic/commit/491f80a1d4146eb9afbec7ef676541c101071fbc))
- enhance README with language options, privacy notice, and license information
  ([b3574bfb](https://github.com/DaoChaShao/csharp-basic/commit/b3574bfbc242e406b1f343cb5d490ac069b52518))
- update README to reflect focus on design principles and SOLID patterns
  ([da741d0a](https://github.com/DaoChaShao/csharp-basic/commit/da741d0a0818aed4d9a90c5ac7e4c776461d0991))
- add README file with instructions for using git-changelog
  ([9b4bfa49](https://github.com/DaoChaShao/csharp-basic/commit/9b4bfa490297c98dab06295d49ab36dd9a1d395c))


## Chore

- update CHANGELOG.md for version 0.1.0 release
  ([5f330803](https://github.com/DaoChaShao/csharp-basic/commit/5f330803e563e28ded35577ad66f8398ab9d3e86))
- update CHANGELOG.md for version 0.1.0 release
  ([e1169218](https://github.com/DaoChaShao/csharp-basic/commit/e1169218d5db7adbbd6859f5b31a34b3048664ed))
- update CHANGELOG.md for version 0.1.0 release
  ([b5a280bb](https://github.com/DaoChaShao/csharp-basic/commit/b5a280bb115c1fb719b3c939330cd74349620882))
- update CHANGELOG.md for version 0.1.0 release
  ([a809dfc4](https://github.com/DaoChaShao/csharp-basic/commit/a809dfc4acce719c8e4a266c659f5ecf3a3f3f8e))
- update CHANGELOG.md for version 0.1.0 release
  ([18a93383](https://github.com/DaoChaShao/csharp-basic/commit/18a93383cb42fdcdd4ebc9cd05a59b1f46bbaa3a))
- update CHANGELOG.md with recent documentation updates
  ([31141fcb](https://github.com/DaoChaShao/csharp-basic/commit/31141fcb9790370590970ca2511bf256c4cafb5b))
- update CHANGELOG.md with recent additions and enhancements
  ([be5c359f](https://github.com/DaoChaShao/csharp-basic/commit/be5c359f6197f4d8bff53215184fcdb85b7ae2d5))
- update CHANGELOG.md with recent documentation enhancements
  ([ff3a0a85](https://github.com/DaoChaShao/csharp-basic/commit/ff3a0a85ee89f36d17c02c5fb60791817bd3b11b))
- update CHANGELOG.md with recent documentation entries
  ([441d7723](https://github.com/DaoChaShao/csharp-basic/commit/441d7723968f64a09ac3bc7553b2763c5c272962))
- update CHANGELOG.md with recent documentation and chore entries
  ([d96eea10](https://github.com/DaoChaShao/csharp-basic/commit/d96eea10e8aaba8ab1a9fb8cb103aa913e471351))
- add initial changelog file
  ([85b18c79](https://github.com/DaoChaShao/csharp-basic/commit/85b18c79dfe9f8422dd65fc88a09a44eed76079f))



---
<sub><sup>*Generated with [git-changelog](https://github.com/rafinskipg/git-changelog). If you have any problems or suggestions, create an issue.* :) **Thanks** </sub></sup>