The **BI/public** branch in this fork of this code is managed by [Business Integrations Ltd](https://github.com/BusinessIntegrations).

A changelog is appended at the end of this file. Further information on our coding standards and approach are detailed [here](https://businessintegrations.github.io/).

***

Orchard Code Prettify Module
============================

Provides code prettify support for formatting code in blog posts. (See: https://code.google.com/p/google-code-prettify/)
* Leverages the Infoset feature of Orchard 1.8
* Enabled CDN Support using cdnjs: http://cdnjs.com/libraries/prettify
* Configured minified and non-minified css and js resources

***

## Business Integrations Changelog

1. Initial Module rework (Public release 1A & 1B)
   * Invalid hex fixed
   * Code tidy
   * Update readme.md
2. Introduced Controller 2018-05-04
   * Amended module to use admin menu / controller instead of driver / site settings menu.
   * Added permission in order to view menu / manage settings.
   * Added basic caching of business data. 
   * Rationalised string constants, updated module version, updated placement info, general code tidy etc.