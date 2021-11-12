(function(){/*

 Copyright The Closure Library Authors.
 SPDX-License-Identifier: Apache-2.0
*/
'use strict';var m;function aa(a){var b=0;return function(){return b<a.length?{done:!1,value:a[b++]}:{done:!0}}}
var ba="function"==typeof Object.defineProperties?Object.defineProperty:function(a,b,c){if(a==Array.prototype||a==Object.prototype)return a;a[b]=c.value;return a};
function ca(a){a=["object"==typeof globalThis&&globalThis,a,"object"==typeof window&&window,"object"==typeof self&&self,"object"==typeof global&&global];for(var b=0;b<a.length;++b){var c=a[b];if(c&&c.Math==Math)return c}throw Error("Cannot find global object");}
var da=ca(this);function r(a,b){if(b)a:{var c=da;a=a.split(".");for(var d=0;d<a.length-1;d++){var e=a[d];if(!(e in c))break a;c=c[e]}a=a[a.length-1];d=c[a];b=b(d);b!=d&&null!=b&&ba(c,a,{configurable:!0,writable:!0,value:b})}}
r("Symbol",function(a){function b(f){if(this instanceof b)throw new TypeError("Symbol is not a constructor");return new c(d+(f||"")+"_"+e++,f)}
function c(f,g){this.h=f;ba(this,"description",{configurable:!0,writable:!0,value:g})}
if(a)return a;c.prototype.toString=function(){return this.h};
var d="jscomp_symbol_"+(1E9*Math.random()>>>0)+"_",e=0;return b});
r("Symbol.iterator",function(a){if(a)return a;a=Symbol("Symbol.iterator");for(var b="Array Int8Array Uint8Array Uint8ClampedArray Int16Array Uint16Array Int32Array Uint32Array Float32Array Float64Array".split(" "),c=0;c<b.length;c++){var d=da[b[c]];"function"===typeof d&&"function"!=typeof d.prototype[a]&&ba(d.prototype,a,{configurable:!0,writable:!0,value:function(){return fa(aa(this))}})}return a});
function fa(a){a={next:a};a[Symbol.iterator]=function(){return this};
return a}
function t(a){var b="undefined"!=typeof Symbol&&Symbol.iterator&&a[Symbol.iterator];return b?b.call(a):{next:aa(a)}}
function ha(a){if(!(a instanceof Array)){a=t(a);for(var b,c=[];!(b=a.next()).done;)c.push(b.value);a=c}return a}
var ia="function"==typeof Object.create?Object.create:function(a){function b(){}
b.prototype=a;return new b},ja;
if("function"==typeof Object.setPrototypeOf)ja=Object.setPrototypeOf;else{var ka;a:{var la={a:!0},ma={};try{ma.__proto__=la;ka=ma.a;break a}catch(a){}ka=!1}ja=ka?function(a,b){a.__proto__=b;if(a.__proto__!==b)throw new TypeError(a+" is not extensible");return a}:null}var na=ja;
function w(a,b){a.prototype=ia(b.prototype);a.prototype.constructor=a;if(na)na(a,b);else for(var c in b)if("prototype"!=c)if(Object.defineProperties){var d=Object.getOwnPropertyDescriptor(b,c);d&&Object.defineProperty(a,c,d)}else a[c]=b[c];a.M=b.prototype}
function oa(){this.u=!1;this.l=null;this.i=void 0;this.h=1;this.m=this.v=0;this.H=this.j=null}
function pa(a){if(a.u)throw new TypeError("Generator is already running");a.u=!0}
oa.prototype.A=function(a){this.i=a};
function ra(a,b){a.j={Na:b,Ra:!0};a.h=a.v||a.m}
oa.prototype.return=function(a){this.j={return:a};this.h=this.m};
function y(a,b,c){a.h=c;return{value:b}}
oa.prototype.o=function(a){this.h=a};
function sa(a,b,c){a.v=b;void 0!=c&&(a.m=c)}
function ta(a,b){a.h=b;a.v=0}
function ua(a){a.v=0;var b=a.j.Na;a.j=null;return b}
function va(a){a.H=[a.j];a.v=0;a.m=0}
function wa(a){var b=a.H.splice(0)[0];(b=a.j=a.j||b)?b.Ra?a.h=a.v||a.m:void 0!=b.o&&a.m<b.o?(a.h=b.o,a.j=null):a.h=a.m:a.h=0}
function xa(a){this.h=new oa;this.i=a}
function ya(a,b){pa(a.h);var c=a.h.l;if(c)return za(a,"return"in c?c["return"]:function(d){return{value:d,done:!0}},b,a.h.return);
a.h.return(b);return Aa(a)}
function za(a,b,c,d){try{var e=b.call(a.h.l,c);if(!(e instanceof Object))throw new TypeError("Iterator result "+e+" is not an object");if(!e.done)return a.h.u=!1,e;var f=e.value}catch(g){return a.h.l=null,ra(a.h,g),Aa(a)}a.h.l=null;d.call(a.h,f);return Aa(a)}
function Aa(a){for(;a.h.h;)try{var b=a.i(a.h);if(b)return a.h.u=!1,{value:b.value,done:!1}}catch(c){a.h.i=void 0,ra(a.h,c)}a.h.u=!1;if(a.h.j){b=a.h.j;a.h.j=null;if(b.Ra)throw b.Na;return{value:b.return,done:!0}}return{value:void 0,done:!0}}
function Ba(a){this.next=function(b){pa(a.h);a.h.l?b=za(a,a.h.l.next,b,a.h.A):(a.h.A(b),b=Aa(a));return b};
this.throw=function(b){pa(a.h);a.h.l?b=za(a,a.h.l["throw"],b,a.h.A):(ra(a.h,b),b=Aa(a));return b};
this.return=function(b){return ya(a,b)};
this[Symbol.iterator]=function(){return this}}
function Ca(a){function b(d){return a.next(d)}
function c(d){return a.throw(d)}
return new Promise(function(d,e){function f(g){g.done?d(g.value):Promise.resolve(g.value).then(b,c).then(f,e)}
f(a.next())})}
function z(a){return Ca(new Ba(new xa(a)))}
function Da(){for(var a=Number(this),b=[],c=a;c<arguments.length;c++)b[c-a]=arguments[c];return b}
r("Reflect.setPrototypeOf",function(a){return a?a:na?function(b,c){try{return na(b,c),!0}catch(d){return!1}}:null});
r("Promise",function(a){function b(g){this.h=0;this.j=void 0;this.i=[];this.u=!1;var h=this.l();try{g(h.resolve,h.reject)}catch(k){h.reject(k)}}
function c(){this.h=null}
function d(g){return g instanceof b?g:new b(function(h){h(g)})}
if(a)return a;c.prototype.i=function(g){if(null==this.h){this.h=[];var h=this;this.j(function(){h.m()})}this.h.push(g)};
var e=da.setTimeout;c.prototype.j=function(g){e(g,0)};
c.prototype.m=function(){for(;this.h&&this.h.length;){var g=this.h;this.h=[];for(var h=0;h<g.length;++h){var k=g[h];g[h]=null;try{k()}catch(l){this.l(l)}}}this.h=null};
c.prototype.l=function(g){this.j(function(){throw g;})};
b.prototype.l=function(){function g(l){return function(n){k||(k=!0,l.call(h,n))}}
var h=this,k=!1;return{resolve:g(this.xa),reject:g(this.m)}};
b.prototype.xa=function(g){if(g===this)this.m(new TypeError("A Promise cannot resolve to itself"));else if(g instanceof b)this.eb(g);else{a:switch(typeof g){case "object":var h=null!=g;break a;case "function":h=!0;break a;default:h=!1}h?this.la(g):this.v(g)}};
b.prototype.la=function(g){var h=void 0;try{h=g.then}catch(k){this.m(k);return}"function"==typeof h?this.fb(h,g):this.v(g)};
b.prototype.m=function(g){this.A(2,g)};
b.prototype.v=function(g){this.A(1,g)};
b.prototype.A=function(g,h){if(0!=this.h)throw Error("Cannot settle("+g+", "+h+"): Promise already settled in state"+this.h);this.h=g;this.j=h;2===this.h&&this.cb();this.H()};
b.prototype.cb=function(){var g=this;e(function(){if(g.N()){var h=da.console;"undefined"!==typeof h&&h.error(g.j)}},1)};
b.prototype.N=function(){if(this.u)return!1;var g=da.CustomEvent,h=da.Event,k=da.dispatchEvent;if("undefined"===typeof k)return!0;"function"===typeof g?g=new g("unhandledrejection",{cancelable:!0}):"function"===typeof h?g=new h("unhandledrejection",{cancelable:!0}):(g=da.document.createEvent("CustomEvent"),g.initCustomEvent("unhandledrejection",!1,!0,g));g.promise=this;g.reason=this.j;return k(g)};
b.prototype.H=function(){if(null!=this.i){for(var g=0;g<this.i.length;++g)f.i(this.i[g]);this.i=null}};
var f=new c;b.prototype.eb=function(g){var h=this.l();g.na(h.resolve,h.reject)};
b.prototype.fb=function(g,h){var k=this.l();try{g.call(h,k.resolve,k.reject)}catch(l){k.reject(l)}};
b.prototype.then=function(g,h){function k(u,q){return"function"==typeof u?function(v){try{l(u(v))}catch(x){n(x)}}:q}
var l,n,p=new b(function(u,q){l=u;n=q});
this.na(k(g,l),k(h,n));return p};
b.prototype.catch=function(g){return this.then(void 0,g)};
b.prototype.na=function(g,h){function k(){switch(l.h){case 1:g(l.j);break;case 2:h(l.j);break;default:throw Error("Unexpected state: "+l.h);}}
var l=this;null==this.i?f.i(k):this.i.push(k);this.u=!0};
b.resolve=d;b.reject=function(g){return new b(function(h,k){k(g)})};
b.race=function(g){return new b(function(h,k){for(var l=t(g),n=l.next();!n.done;n=l.next())d(n.value).na(h,k)})};
b.all=function(g){var h=t(g),k=h.next();return k.done?d([]):new b(function(l,n){function p(v){return function(x){u[v]=x;q--;0==q&&l(u)}}
var u=[],q=0;do u.push(void 0),q++,d(k.value).na(p(u.length-1),n),k=h.next();while(!k.done)})};
return b});
function Ea(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
r("WeakMap",function(a){function b(k){this.h=(h+=Math.random()+1).toString();if(k){k=t(k);for(var l;!(l=k.next()).done;)l=l.value,this.set(l[0],l[1])}}
function c(){}
function d(k){var l=typeof k;return"object"===l&&null!==k||"function"===l}
function e(k){if(!Ea(k,g)){var l=new c;ba(k,g,{value:l})}}
function f(k){var l=Object[k];l&&(Object[k]=function(n){if(n instanceof c)return n;Object.isExtensible(n)&&e(n);return l(n)})}
if(function(){if(!a||!Object.seal)return!1;try{var k=Object.seal({}),l=Object.seal({}),n=new a([[k,2],[l,3]]);if(2!=n.get(k)||3!=n.get(l))return!1;n.delete(k);n.set(l,4);return!n.has(k)&&4==n.get(l)}catch(p){return!1}}())return a;
var g="$jscomp_hidden_"+Math.random();f("freeze");f("preventExtensions");f("seal");var h=0;b.prototype.set=function(k,l){if(!d(k))throw Error("Invalid WeakMap key");e(k);if(!Ea(k,g))throw Error("WeakMap key fail: "+k);k[g][this.h]=l;return this};
b.prototype.get=function(k){return d(k)&&Ea(k,g)?k[g][this.h]:void 0};
b.prototype.has=function(k){return d(k)&&Ea(k,g)&&Ea(k[g],this.h)};
b.prototype.delete=function(k){return d(k)&&Ea(k,g)&&Ea(k[g],this.h)?delete k[g][this.h]:!1};
return b});
r("Map",function(a){function b(){var h={};return h.previous=h.next=h.head=h}
function c(h,k){var l=h.h;return fa(function(){if(l){for(;l.head!=h.h;)l=l.previous;for(;l.next!=l.head;)return l=l.next,{done:!1,value:k(l)};l=null}return{done:!0,value:void 0}})}
function d(h,k){var l=k&&typeof k;"object"==l||"function"==l?f.has(k)?l=f.get(k):(l=""+ ++g,f.set(k,l)):l="p_"+k;var n=h.data_[l];if(n&&Ea(h.data_,l))for(h=0;h<n.length;h++){var p=n[h];if(k!==k&&p.key!==p.key||k===p.key)return{id:l,list:n,index:h,entry:p}}return{id:l,list:n,index:-1,entry:void 0}}
function e(h){this.data_={};this.h=b();this.size=0;if(h){h=t(h);for(var k;!(k=h.next()).done;)k=k.value,this.set(k[0],k[1])}}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var h=Object.seal({x:4}),k=new a(t([[h,"s"]]));if("s"!=k.get(h)||1!=k.size||k.get({x:4})||k.set({x:4},"t")!=k||2!=k.size)return!1;var l=k.entries(),n=l.next();if(n.done||n.value[0]!=h||"s"!=n.value[1])return!1;n=l.next();return n.done||4!=n.value[0].x||"t"!=n.value[1]||!l.next().done?!1:!0}catch(p){return!1}}())return a;
var f=new WeakMap;e.prototype.set=function(h,k){h=0===h?0:h;var l=d(this,h);l.list||(l.list=this.data_[l.id]=[]);l.entry?l.entry.value=k:(l.entry={next:this.h,previous:this.h.previous,head:this.h,key:h,value:k},l.list.push(l.entry),this.h.previous.next=l.entry,this.h.previous=l.entry,this.size++);return this};
e.prototype.delete=function(h){h=d(this,h);return h.entry&&h.list?(h.list.splice(h.index,1),h.list.length||delete this.data_[h.id],h.entry.previous.next=h.entry.next,h.entry.next.previous=h.entry.previous,h.entry.head=null,this.size--,!0):!1};
e.prototype.clear=function(){this.data_={};this.h=this.h.previous=b();this.size=0};
e.prototype.has=function(h){return!!d(this,h).entry};
e.prototype.get=function(h){return(h=d(this,h).entry)&&h.value};
e.prototype.entries=function(){return c(this,function(h){return[h.key,h.value]})};
e.prototype.keys=function(){return c(this,function(h){return h.key})};
e.prototype.values=function(){return c(this,function(h){return h.value})};
e.prototype.forEach=function(h,k){for(var l=this.entries(),n;!(n=l.next()).done;)n=n.value,h.call(k,n[1],n[0],this)};
e.prototype[Symbol.iterator]=e.prototype.entries;var g=0;return e});
function Fa(a,b,c){if(null==a)throw new TypeError("The 'this' value for String.prototype."+c+" must not be null or undefined");if(b instanceof RegExp)throw new TypeError("First argument to String.prototype."+c+" must not be a regular expression");return a+""}
r("String.prototype.endsWith",function(a){return a?a:function(b,c){var d=Fa(this,b,"endsWith");b+="";void 0===c&&(c=d.length);c=Math.max(0,Math.min(c|0,d.length));for(var e=b.length;0<e&&0<c;)if(d[--c]!=b[--e])return!1;return 0>=e}});
r("Array.prototype.find",function(a){return a?a:function(b,c){a:{var d=this;d instanceof String&&(d=String(d));for(var e=d.length,f=0;f<e;f++){var g=d[f];if(b.call(c,g,f,d)){b=g;break a}}b=void 0}return b}});
r("String.prototype.startsWith",function(a){return a?a:function(b,c){var d=Fa(this,b,"startsWith");b+="";var e=d.length,f=b.length;c=Math.max(0,Math.min(c|0,d.length));for(var g=0;g<f&&c<e;)if(d[c++]!=b[g++])return!1;return g>=f}});
function Ga(a,b){a instanceof String&&(a+="");var c=0,d=!1,e={next:function(){if(!d&&c<a.length){var f=c++;return{value:b(f,a[f]),done:!1}}d=!0;return{done:!0,value:void 0}}};
e[Symbol.iterator]=function(){return e};
return e}
r("Array.prototype.entries",function(a){return a?a:function(){return Ga(this,function(b,c){return[b,c]})}});
r("Object.setPrototypeOf",function(a){return a||na});
var Ha="function"==typeof Object.assign?Object.assign:function(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(d)for(var e in d)Ea(d,e)&&(a[e]=d[e])}return a};
r("Object.assign",function(a){return a||Ha});
r("Set",function(a){function b(c){this.h=new Map;if(c){c=t(c);for(var d;!(d=c.next()).done;)this.add(d.value)}this.size=this.h.size}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var c=Object.seal({x:4}),d=new a(t([c]));if(!d.has(c)||1!=d.size||d.add(c)!=d||1!=d.size||d.add({x:4})!=d||2!=d.size)return!1;var e=d.entries(),f=e.next();if(f.done||f.value[0]!=c||f.value[1]!=c)return!1;f=e.next();return f.done||f.value[0]==c||4!=f.value[0].x||f.value[1]!=f.value[0]?!1:e.next().done}catch(g){return!1}}())return a;
b.prototype.add=function(c){c=0===c?0:c;this.h.set(c,c);this.size=this.h.size;return this};
b.prototype.delete=function(c){c=this.h.delete(c);this.size=this.h.size;return c};
b.prototype.clear=function(){this.h.clear();this.size=0};
b.prototype.has=function(c){return this.h.has(c)};
b.prototype.entries=function(){return this.h.entries()};
b.prototype.values=function(){return this.h.values()};
b.prototype.keys=b.prototype.values;b.prototype[Symbol.iterator]=b.prototype.values;b.prototype.forEach=function(c,d){var e=this;this.h.forEach(function(f){return c.call(d,f,f,e)})};
return b});
r("Object.entries",function(a){return a?a:function(b){var c=[],d;for(d in b)Ea(b,d)&&c.push([d,b[d]]);return c}});
r("Array.prototype.keys",function(a){return a?a:function(){return Ga(this,function(b){return b})}});
r("Array.prototype.values",function(a){return a?a:function(){return Ga(this,function(b,c){return c})}});
r("Array.from",function(a){return a?a:function(b,c,d){c=null!=c?c:function(h){return h};
var e=[],f="undefined"!=typeof Symbol&&Symbol.iterator&&b[Symbol.iterator];if("function"==typeof f){b=f.call(b);for(var g=0;!(f=b.next()).done;)e.push(c.call(d,f.value,g++))}else for(f=b.length,g=0;g<f;g++)e.push(c.call(d,b[g],g));return e}});
r("Number.isNaN",function(a){return a?a:function(b){return"number"===typeof b&&isNaN(b)}});
r("Number.MAX_SAFE_INTEGER",function(){return 9007199254740991});
r("Object.is",function(a){return a?a:function(b,c){return b===c?0!==b||1/b===1/c:b!==b&&c!==c}});
r("Array.prototype.includes",function(a){return a?a:function(b,c){var d=this;d instanceof String&&(d=String(d));var e=d.length;c=c||0;for(0>c&&(c=Math.max(c+e,0));c<e;c++){var f=d[c];if(f===b||Object.is(f,b))return!0}return!1}});
r("String.prototype.includes",function(a){return a?a:function(b,c){return-1!==Fa(this,b,"includes").indexOf(b,c||0)}});
var B=this||self;function C(a,b){a=a.split(".");b=b||B;for(var c=0;c<a.length;c++)if(b=b[a[c]],null==b)return null;return b}
function Ia(){}
function Ja(a){var b=typeof a;return"object"!=b?b:a?Array.isArray(a)?"array":b:"null"}
function Ka(a){var b=Ja(a);return"array"==b||"object"==b&&"number"==typeof a.length}
function D(a){var b=typeof a;return"object"==b&&null!=a||"function"==b}
function La(a){return Object.prototype.hasOwnProperty.call(a,Ma)&&a[Ma]||(a[Ma]=++Na)}
var Ma="closure_uid_"+(1E9*Math.random()>>>0),Na=0;function Oa(a,b,c){return a.call.apply(a.bind,arguments)}
function Pa(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var e=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(e,d);return a.apply(b,e)}}return function(){return a.apply(b,arguments)}}
function Qa(a,b,c){Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?Qa=Oa:Qa=Pa;return Qa.apply(null,arguments)}
function E(a,b){a=a.split(".");var c=B;a[0]in c||"undefined"==typeof c.execScript||c.execScript("var "+a[0]);for(var d;a.length&&(d=a.shift());)a.length||void 0===b?c[d]&&c[d]!==Object.prototype[d]?c=c[d]:c=c[d]={}:c[d]=b}
function F(a,b){function c(){}
c.prototype=b.prototype;a.M=b.prototype;a.prototype=new c;a.prototype.constructor=a;a.Jb=function(d,e,f){for(var g=Array(arguments.length-2),h=2;h<arguments.length;h++)g[h-2]=arguments[h];return b.prototype[e].apply(d,g)}}
function Ra(a){return a}
;function Sa(a,b){if(Error.captureStackTrace)Error.captureStackTrace(this,Sa);else{var c=Error().stack;c&&(this.stack=c)}a&&(this.message=String(a));void 0!==b&&(this.hb=b)}
F(Sa,Error);Sa.prototype.name="CustomError";function Ta(a){a=a.url;var b=/[?&]dsh=1(&|$)/.test(a);this.j=!b&&/[?&]ae=1(&|$)/.test(a);this.l=!b&&/[?&]ae=2(&|$)/.test(a);if((this.h=/[?&]adurl=([^&]*)/.exec(a))&&this.h[1]){try{var c=decodeURIComponent(this.h[1])}catch(d){c=null}this.i=c}}
;function Ua(a){var b=!1,c;return function(){b||(c=a(),b=!0);return c}}
;var Va=Array.prototype.indexOf?function(a,b){return Array.prototype.indexOf.call(a,b,void 0)}:function(a,b){if("string"===typeof a)return"string"!==typeof b||1!=b.length?-1:a.indexOf(b,0);
for(var c=0;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},G=Array.prototype.forEach?function(a,b,c){Array.prototype.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e="string"===typeof a?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},Wa=Array.prototype.reduce?function(a,b,c){return Array.prototype.reduce.call(a,b,c)}:function(a,b,c){var d=c;
G(a,function(e,f){d=b.call(void 0,d,e,f,a)});
return d};
function Xa(a,b){b=Va(a,b);var c;(c=0<=b)&&Array.prototype.splice.call(a,b,1);return c}
function Ya(a){return Array.prototype.concat.apply([],arguments)}
function Za(a){var b=a.length;if(0<b){for(var c=Array(b),d=0;d<b;d++)c[d]=a[d];return c}return[]}
function $a(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(Ka(d)){var e=a.length||0,f=d.length||0;a.length=e+f;for(var g=0;g<f;g++)a[e+g]=d[g]}else a.push(d)}}
;function ab(a,b){for(var c in a)b.call(void 0,a[c],c,a)}
function bb(a){var b=db,c;for(c in b)if(a.call(void 0,b[c],c,b))return c}
function eb(a,b){for(var c in a)if(!(c in b)||a[c]!==b[c])return!1;for(var d in b)if(!(d in a))return!1;return!0}
function fb(a){if(!a||"object"!==typeof a)return a;if("function"===typeof a.clone)return a.clone();if("undefined"!==typeof Map&&a instanceof Map)return new Map(a);if("undefined"!==typeof Set&&a instanceof Set)return new Set(a);var b=Array.isArray(a)?[]:"function"!==typeof ArrayBuffer||"function"!==typeof ArrayBuffer.isView||!ArrayBuffer.isView(a)||a instanceof DataView?{}:new a.constructor(a.length),c;for(c in a)b[c]=fb(a[c]);return b}
var gb="constructor hasOwnProperty isPrototypeOf propertyIsEnumerable toLocaleString toString valueOf".split(" ");function hb(a,b){for(var c,d,e=1;e<arguments.length;e++){d=arguments[e];for(c in d)a[c]=d[c];for(var f=0;f<gb.length;f++)c=gb[f],Object.prototype.hasOwnProperty.call(d,c)&&(a[c]=d[c])}}
;var ib;function jb(a,b){this.h=a===kb&&b||""}
jb.prototype.ga=!0;jb.prototype.fa=function(){return this.h};
function lb(a){return new jb(kb,a)}
var kb={};lb("");var mb=String.prototype.trim?function(a){return a.trim()}:function(a){return/^[\s\xa0]*([\s\S]*?)[\s\xa0]*$/.exec(a)[1]};
function nb(a,b){if(b)a=a.replace(ob,"&amp;").replace(pb,"&lt;").replace(qb,"&gt;").replace(rb,"&quot;").replace(sb,"&#39;").replace(tb,"&#0;");else{if(!ub.test(a))return a;-1!=a.indexOf("&")&&(a=a.replace(ob,"&amp;"));-1!=a.indexOf("<")&&(a=a.replace(pb,"&lt;"));-1!=a.indexOf(">")&&(a=a.replace(qb,"&gt;"));-1!=a.indexOf('"')&&(a=a.replace(rb,"&quot;"));-1!=a.indexOf("'")&&(a=a.replace(sb,"&#39;"));-1!=a.indexOf("\x00")&&(a=a.replace(tb,"&#0;"))}return a}
var ob=/&/g,pb=/</g,qb=/>/g,rb=/"/g,sb=/'/g,tb=/\x00/g,ub=/[\x00&<>"']/;function vb(a,b){this.h=b===wb?a:""}
m=vb.prototype;m.ga=!0;m.fa=function(){return this.h.toString()};
m.Qa=!0;m.Oa=function(){return 1};
m.toString=function(){return this.h.toString()};
var xb=RegExp('^(?:audio/(?:3gpp2|3gpp|aac|L16|midi|mp3|mp4|mpeg|oga|ogg|opus|x-m4a|x-matroska|x-wav|wav|webm)|font/\\w+|image/(?:bmp|gif|jpeg|jpg|png|tiff|webp|x-icon)|video/(?:mpeg|mp4|ogg|webm|quicktime|x-matroska))(?:;\\w+=(?:\\w+|"[\\w;,= ]+"))*$',"i"),yb=/^data:(.*);base64,[a-z0-9+\/]+=*$/i,zb=/^(?:(?:https?|mailto|ftp):|[^:/?#]*(?:[/?#]|$))/i,wb={},Ab=new vb("about:invalid#zClosurez",wb);var Bb;a:{var Db=B.navigator;if(Db){var Eb=Db.userAgent;if(Eb){Bb=Eb;break a}}Bb=""}function H(a){return-1!=Bb.indexOf(a)}
;function Fb(){return(H("Chrome")||H("CriOS"))&&!H("Edge")}
;var Gb={};function Hb(a,b,c){this.h=c===Gb?a:"";this.i=b;this.ga=this.Qa=!0}
Hb.prototype.Oa=function(){return this.i};
Hb.prototype.fa=function(){return this.h.toString()};
Hb.prototype.toString=function(){return this.h.toString()};
function Ib(a,b){if(void 0===ib){var c=null;var d=B.trustedTypes;if(d&&d.createPolicy){try{c=d.createPolicy("goog#html",{createHTML:Ra,createScript:Ra,createScriptURL:Ra})}catch(e){B.console&&B.console.error(e.message)}ib=c}else ib=c}a=(c=ib)?c.createHTML(a):a;return new Hb(a,b,Gb)}
;var Jb=RegExp("^(?:([^:/?#.]+):)?(?://(?:([^\\\\/?#]*)@)?([^\\\\/?#]*?)(?::([0-9]+))?(?=[\\\\/?#]|$))?([^?#]+)?(?:\\?([^#]*))?(?:#([\\s\\S]*))?$");function Kb(a){return a?decodeURI(a):a}
function Lb(a){return Kb(a.match(Jb)[3]||null)}
function Mb(a){var b=a.match(Jb);a=b[1];var c=b[2],d=b[3];b=b[4];var e="";a&&(e+=a+":");d&&(e+="//",c&&(e+=c+"@"),e+=d,b&&(e+=":"+b));return e}
function Nb(a,b,c){if(Array.isArray(b))for(var d=0;d<b.length;d++)Nb(a,String(b[d]),c);else null!=b&&c.push(a+(""===b?"":"="+encodeURIComponent(String(b))))}
function Ob(a){var b=[],c;for(c in a)Nb(c,a[c],b);return b.join("&")}
var Pb=/#|$/;function Qb(a,b){var c=a.search(Pb);a:{var d=0;for(var e=b.length;0<=(d=a.indexOf(b,d))&&d<c;){var f=a.charCodeAt(d-1);if(38==f||63==f)if(f=a.charCodeAt(d+e),!f||61==f||38==f||35==f)break a;d+=e+1}d=-1}if(0>d)return null;e=a.indexOf("&",d);if(0>e||e>c)e=c;d+=b.length+1;return decodeURIComponent(a.substr(d,e-d).replace(/\+/g," "))}
;function Rb(a){B.setTimeout(function(){throw a;},0)}
;function Sb(){return H("iPhone")&&!H("iPod")&&!H("iPad")}
;function Tb(a){Tb[" "](a);return a}
Tb[" "]=Ia;var Ub=H("Opera"),Vb=H("Trident")||H("MSIE"),Wb=H("Edge"),Xb=H("Gecko")&&!(-1!=Bb.toLowerCase().indexOf("webkit")&&!H("Edge"))&&!(H("Trident")||H("MSIE"))&&!H("Edge"),Yb=-1!=Bb.toLowerCase().indexOf("webkit")&&!H("Edge");function Zb(){var a=B.document;return a?a.documentMode:void 0}
var $b;a:{var ac="",bc=function(){var a=Bb;if(Xb)return/rv:([^\);]+)(\)|;)/.exec(a);if(Wb)return/Edge\/([\d\.]+)/.exec(a);if(Vb)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(Yb)return/WebKit\/(\S+)/.exec(a);if(Ub)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
bc&&(ac=bc?bc[1]:"");if(Vb){var cc=Zb();if(null!=cc&&cc>parseFloat(ac)){$b=String(cc);break a}}$b=ac}var dc=$b,ec;if(B.document&&Vb){var fc=Zb();ec=fc?fc:parseInt(dc,10)||void 0}else ec=void 0;var gc=ec;var hc=Sb()||H("iPod"),ic=H("iPad");!H("Android")||Fb();Fb();var jc=H("Safari")&&!(Fb()||H("Coast")||H("Opera")||H("Edge")||H("Edg/")||H("OPR")||H("Firefox")||H("FxiOS")||H("Silk")||H("Android"))&&!(Sb()||H("iPad")||H("iPod"));var kc={},lc=null;
function mc(a,b){Ka(a);void 0===b&&(b=0);if(!lc){lc={};for(var c="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".split(""),d=["+/=","+/","-_=","-_.","-_"],e=0;5>e;e++){var f=c.concat(d[e].split(""));kc[e]=f;for(var g=0;g<f.length;g++){var h=f[g];void 0===lc[h]&&(lc[h]=g)}}}b=kc[b];c=Array(Math.floor(a.length/3));d=b[64]||"";for(e=f=0;f<a.length-2;f+=3){var k=a[f],l=a[f+1];h=a[f+2];g=b[k>>2];k=b[(k&3)<<4|l>>4];l=b[(l&15)<<2|h>>6];h=b[h&63];c[e++]=""+g+k+l+h}g=0;h=d;switch(a.length-
f){case 2:g=a[f+1],h=b[(g&15)<<2]||d;case 1:a=a[f],c[e]=""+b[a>>2]+b[(a&3)<<4|g>>4]+h+d}return c.join("")}
;var nc="function"===typeof Uint8Array;var oc="function"===typeof Symbol&&"symbol"===typeof Symbol()?Symbol(void 0):void 0;function pc(a){if(!Array.isArray(a))return a;Object.isFrozen(a)||(oc?a[oc]|=1:void 0!==a.h?a.h|=1:Object.defineProperties(a,{h:{value:1,configurable:!0,writable:!0,enumerable:!1}}));return a}
;function qc(a){return null!==a&&"object"===typeof a&&a.constructor===Object}
function rc(a){switch(typeof a){case "number":return isFinite(a)?a:String(a);case "object":return nc&&null!=a&&a instanceof Uint8Array?mc(a):a;default:return a}}
;function sc(a,b){if(null!=a)return Array.isArray(a)||qc(a)?tc(a,b):b(a)}
function tc(a,b){if(Array.isArray(a)){for(var c=Array(a.length),d=0;d<a.length;d++)c[d]=sc(a[d],b);if(a){var e;oc?e=a[oc]:e=a.h;a=null==e?0:e}else a=0;a&1&&pc(c);return c}e={};for(c in a)e[c]=sc(a[c],b);return e}
function uc(a){return nc&&null!=a&&a instanceof Uint8Array?new Uint8Array(a):a}
;function vc(a,b){this.i=a;this.j=b;this.h={};this.l=!0;if(0<this.i.length){for(a=0;a<this.i.length;a++){b=this.i[a];var c=b[0];this.h[c.toString()]=new wc(c,b[1])}this.l=!0}}
m=vc.prototype;m.S=function(){if(this.l){if(this.j){var a=this.h,b;for(b in a)if(Object.prototype.hasOwnProperty.call(a,b)){var c=a[b].h;c&&c.S()}}}else{this.i.length=0;a=xc(this);a.sort();for(b=0;b<a.length;b++){c=this.h[a[b]];var d=c.h;d&&d.S();this.i.push([c.key,c.value])}this.l=!0}return this.i};
m.clear=function(){this.h={};this.l=!1};
m.entries=function(){var a=[],b=xc(this);b.sort();for(var c=0;c<b.length;c++){var d=this.h[b[c]];a.push([d.key,yc(this,d)])}return new zc(a)};
m.keys=function(){var a=[],b=xc(this);b.sort();for(var c=0;c<b.length;c++)a.push(this.h[b[c]].key);return new zc(a)};
m.values=function(){var a=[],b=xc(this);b.sort();for(var c=0;c<b.length;c++)a.push(yc(this,this.h[b[c]]));return new zc(a)};
m.forEach=function(a,b){var c=xc(this);c.sort();for(var d=0;d<c.length;d++){var e=this.h[c[d]];a.call(b,yc(this,e),e.key,this)}};
m.set=function(a,b){var c=new wc(a);this.j?(c.h=b,c.value=b.S()):c.value=b;this.h[a.toString()]=c;this.l=!1;return this};
function yc(a,b){return a.j?(b.h||(b.h=new a.j(b.value)),b.h):b.value}
m.get=function(a){if(a=this.h[a.toString()])return yc(this,a)};
m.has=function(a){return a.toString()in this.h};
function xc(a){a=a.h;var b=[],c;for(c in a)Object.prototype.hasOwnProperty.call(a,c)&&b.push(c);return b}
vc.prototype[Symbol.iterator]=function(){return this.entries()};
function wc(a,b){this.key=a;this.value=b;this.h=void 0}
function zc(a){this.i=0;this.h=a}
zc.prototype.next=function(){return this.i<this.h.length?{done:!1,value:this.h[this.i++]}:{done:!0,value:void 0}};
zc.prototype[Symbol.iterator]=function(){return this};var Ac;function Bc(a,b,c){var d=Ac;Ac=null;a||(a=d);d=this.constructor.Ob;a||(a=d?[d]:[]);this.l=(d?0:-1)-(this.constructor.Nb||0);this.h=null;this.i=a;a:{d=this.i.length;a=d-1;if(d&&(d=this.i[a],qc(d))){this.m=a-this.l;this.j=d;break a}void 0!==b&&-1<b?(this.m=Math.max(b,a+1-this.l),this.j=null):this.m=Number.MAX_VALUE}if(c)for(b=0;b<c.length;b++)a=c[b],a<this.m?(a+=this.l,(d=this.i[a])?pc(d):this.i[a]=Cc):(Dc(this),(d=this.j[a])?pc(d):this.j[a]=Cc)}
var Cc=Object.freeze(pc([]));function Dc(a){var b=a.m+a.l;a.i[b]||(a.j=a.i[b]={})}
function Ec(a,b,c){return-1===b?null:(void 0===c?0:c)||b>=a.m?a.j?a.j[b]:void 0:a.i[b+a.l]}
function Fc(a,b,c){a.h||(a.h={});if(b in a.h)return a.h[b];var d=Ec(a,b);d||(d=pc([]),Gc(a,b,d));c=new vc(d,c);return a.h[b]=c}
function Gc(a,b,c,d){(void 0===d?0:d)||b>=a.m?(Dc(a),a.j[b]=c):a.i[b+a.l]=c}
function Hc(a,b,c,d){if(-1===c)return null;a.h||(a.h={});var e=a.h[c];if(e)return e;d=Ec(a,c,void 0===d?!1:d);if(null==d)return e;b=new b(d);return a.h[c]=b}
function Ic(a,b,c){a.h||(a.h={});var d=a.h[c];if(!d){var e=void 0===e?!1:e;d=Ec(a,c,e);null==d&&(d=Cc);d===Cc&&(d=pc(d.slice()),Gc(a,c,d,e));e=d;d=[];for(var f=0;f<e.length;f++)d[f]=new b(e[f]);a.h[c]=d}return d}
Bc.prototype.toJSON=function(){var a=this.S();return tc(a,rc)};
Bc.prototype.S=function(){if(this.h)for(var a in this.h){var b=this.h[a];if(Array.isArray(b))for(var c=0;c<b.length;c++)b[c]&&b[c].S();else b&&b.S()}return this.i};
Bc.prototype.toString=function(){return this.S().toString()};
Bc.prototype.clone=function(){var a=this.constructor,b=tc(this.S(),uc);Ac=b;a=new a(b);Ac=null;Jc(a,this);return a};
function Jc(a,b){b.v&&(a.v=b.v.slice());var c=b.h;if(c){b=b.j;var d={},e;for(e in c){var f=c[e];if(f){var g=!(!b||!b[e]),h=+e;if(Array.isArray(f)){if(f.length)for(g=Ic(a,f[0].constructor,h,g),h=0;h<Math.min(g.length,f.length);h++)Jc(g[h],f[h])}else f instanceof vc?f.j&&(d.wa=Fc(a,h,f.j),f.forEach(function(k){return function(l,n){return Jc(k.wa.get(n),l)}}(d))):(g=Hc(a,f.constructor,h,g))&&Jc(g,f)}d={wa:d.wa}}}}
;var Kc=window;lb("csi.gstatic.com");lb("googleads.g.doubleclick.net");lb("pagead2.googlesyndication.com");lb("partner.googleadservices.com");lb("pubads.g.doubleclick.net");lb("securepubads.g.doubleclick.net");lb("tpc.googlesyndication.com");/*

 SPDX-License-Identifier: Apache-2.0
*/
function Lc(a,b){this.width=a;this.height=b}
m=Lc.prototype;m.clone=function(){return new Lc(this.width,this.height)};
m.aspectRatio=function(){return this.width/this.height};
m.isEmpty=function(){return!(this.width*this.height)};
m.ceil=function(){this.width=Math.ceil(this.width);this.height=Math.ceil(this.height);return this};
m.floor=function(){this.width=Math.floor(this.width);this.height=Math.floor(this.height);return this};
m.round=function(){this.width=Math.round(this.width);this.height=Math.round(this.height);return this};
m.scale=function(a,b){this.width*=a;this.height*="number"===typeof b?b:a;return this};function Mc(a,b){ab(b,function(c,d){c&&"object"==typeof c&&c.ga&&(c=c.fa());"style"==d?a.style.cssText=c:"class"==d?a.className=c:"for"==d?a.htmlFor=c:Nc.hasOwnProperty(d)?a.setAttribute(Nc[d],c):0==d.lastIndexOf("aria-",0)||0==d.lastIndexOf("data-",0)?a.setAttribute(d,c):a[d]=c})}
var Nc={cellpadding:"cellPadding",cellspacing:"cellSpacing",colspan:"colSpan",frameborder:"frameBorder",height:"height",maxlength:"maxLength",nonce:"nonce",role:"role",rowspan:"rowSpan",type:"type",usemap:"useMap",valign:"vAlign",width:"width"};function Oc(a,b,c){var d=arguments,e=document,f=d[1],g=Pc(e,String(d[0]));f&&("string"===typeof f?g.className=f:Array.isArray(f)?g.className=f.join(" "):Mc(g,f));2<d.length&&Qc(e,g,d);return g}
function Qc(a,b,c){function d(h){h&&b.appendChild("string"===typeof h?a.createTextNode(h):h)}
for(var e=2;e<c.length;e++){var f=c[e];if(!Ka(f)||D(f)&&0<f.nodeType)d(f);else{a:{if(f&&"number"==typeof f.length){if(D(f)){var g="function"==typeof f.item||"string"==typeof f.item;break a}if("function"===typeof f){g="function"==typeof f.item;break a}}g=!1}G(g?Za(f):f,d)}}}
function Pc(a,b){b=String(b);"application/xhtml+xml"===a.contentType&&(b=b.toLowerCase());return a.createElement(b)}
function Rc(a,b){for(var c=0;a;){if(b(a))return a;a=a.parentNode;c++}return null}
;function Sc(a){var b=Tc;if(b)for(var c in b)Object.prototype.hasOwnProperty.call(b,c)&&a.call(void 0,b[c],c,b)}
function Uc(){var a=[];Sc(function(b){a.push(b)});
return a}
var Tc={wb:"allow-forms",xb:"allow-modals",yb:"allow-orientation-lock",zb:"allow-pointer-lock",Ab:"allow-popups",Bb:"allow-popups-to-escape-sandbox",Cb:"allow-presentation",Db:"allow-same-origin",Eb:"allow-scripts",Fb:"allow-top-navigation",Gb:"allow-top-navigation-by-user-activation"},Vc=Ua(function(){return Uc()});
function Wc(){var a=Xc(),b={};G(Vc(),function(c){a.sandbox&&a.sandbox.supports&&a.sandbox.supports(c)&&(b[c]=!0)});
return b}
function Xc(){var a=void 0===a?document:a;return a.createElement("iframe")}
;var Yc=(new Date).getTime();function Zc(a){if(!a)return"";a=a.split("#")[0].split("?")[0];a=a.toLowerCase();0==a.indexOf("//")&&(a=window.location.protocol+a);/^[\w\-]*:\/\//.test(a)||(a=window.location.href);var b=a.substring(a.indexOf("://")+3),c=b.indexOf("/");-1!=c&&(b=b.substring(0,c));c=a.substring(0,a.indexOf("://"));if(!c)throw Error("URI is missing protocol: "+a);if("http"!==c&&"https"!==c&&"chrome-extension"!==c&&"moz-extension"!==c&&"file"!==c&&"android-app"!==c&&"chrome-search"!==c&&"chrome-untrusted"!==c&&"chrome"!==
c&&"app"!==c&&"devtools"!==c)throw Error("Invalid URI scheme in origin: "+c);a="";var d=b.indexOf(":");if(-1!=d){var e=b.substring(d+1);b=b.substring(0,d);if("http"===c&&"80"!==e||"https"===c&&"443"!==e)a=":"+e}return c+"://"+b+a}
;function $c(){function a(){e[0]=1732584193;e[1]=4023233417;e[2]=2562383102;e[3]=271733878;e[4]=3285377520;n=l=0}
function b(p){for(var u=g,q=0;64>q;q+=4)u[q/4]=p[q]<<24|p[q+1]<<16|p[q+2]<<8|p[q+3];for(q=16;80>q;q++)p=u[q-3]^u[q-8]^u[q-14]^u[q-16],u[q]=(p<<1|p>>>31)&4294967295;p=e[0];var v=e[1],x=e[2],A=e[3],J=e[4];for(q=0;80>q;q++){if(40>q)if(20>q){var K=A^v&(x^A);var M=1518500249}else K=v^x^A,M=1859775393;else 60>q?(K=v&x|A&(v|x),M=2400959708):(K=v^x^A,M=3395469782);K=((p<<5|p>>>27)&4294967295)+K+J+M+u[q]&4294967295;J=A;A=x;x=(v<<30|v>>>2)&4294967295;v=p;p=K}e[0]=e[0]+p&4294967295;e[1]=e[1]+v&4294967295;e[2]=
e[2]+x&4294967295;e[3]=e[3]+A&4294967295;e[4]=e[4]+J&4294967295}
function c(p,u){if("string"===typeof p){p=unescape(encodeURIComponent(p));for(var q=[],v=0,x=p.length;v<x;++v)q.push(p.charCodeAt(v));p=q}u||(u=p.length);q=0;if(0==l)for(;q+64<u;)b(p.slice(q,q+64)),q+=64,n+=64;for(;q<u;)if(f[l++]=p[q++],n++,64==l)for(l=0,b(f);q+64<u;)b(p.slice(q,q+64)),q+=64,n+=64}
function d(){var p=[],u=8*n;56>l?c(h,56-l):c(h,64-(l-56));for(var q=63;56<=q;q--)f[q]=u&255,u>>>=8;b(f);for(q=u=0;5>q;q++)for(var v=24;0<=v;v-=8)p[u++]=e[q]>>v&255;return p}
for(var e=[],f=[],g=[],h=[128],k=1;64>k;++k)h[k]=0;var l,n;a();return{reset:a,update:c,digest:d,jb:function(){for(var p=d(),u="",q=0;q<p.length;q++)u+="0123456789ABCDEF".charAt(Math.floor(p[q]/16))+"0123456789ABCDEF".charAt(p[q]%16);return u}}}
;function ad(a,b,c){var d=String(B.location.href);return d&&a&&b?[b,bd(Zc(d),a,c||null)].join(" "):null}
function bd(a,b,c){var d=[],e=[];if(1==(Array.isArray(c)?2:1))return e=[b,a],G(d,function(h){e.push(h)}),cd(e.join(" "));
var f=[],g=[];G(c,function(h){g.push(h.key);f.push(h.value)});
c=Math.floor((new Date).getTime()/1E3);e=0==f.length?[c,b,a]:[f.join(":"),c,b,a];G(d,function(h){e.push(h)});
a=cd(e.join(" "));a=[c,a];0==g.length||a.push(g.join(""));return a.join("_")}
function cd(a){var b=$c();b.update(a);return b.jb().toLowerCase()}
;var dd={};function ed(a){this.h=a||{cookie:""}}
m=ed.prototype;m.isEnabled=function(){if(!B.navigator.cookieEnabled)return!1;if(!this.isEmpty())return!0;this.set("TESTCOOKIESENABLED","1",{Ca:60});if("1"!==this.get("TESTCOOKIESENABLED"))return!1;this.remove("TESTCOOKIESENABLED");return!0};
m.set=function(a,b,c){var d=!1;if("object"===typeof c){var e=c.Rb;d=c.secure||!1;var f=c.domain||void 0;var g=c.path||void 0;var h=c.Ca}if(/[;=\s]/.test(a))throw Error('Invalid cookie name "'+a+'"');if(/[;\r\n]/.test(b))throw Error('Invalid cookie value "'+b+'"');void 0===h&&(h=-1);c=f?";domain="+f:"";g=g?";path="+g:"";d=d?";secure":"";h=0>h?"":0==h?";expires="+(new Date(1970,1,1)).toUTCString():";expires="+(new Date(Date.now()+1E3*h)).toUTCString();this.h.cookie=a+"="+b+c+g+h+d+(null!=e?";samesite="+
e:"")};
m.get=function(a,b){for(var c=a+"=",d=(this.h.cookie||"").split(";"),e=0,f;e<d.length;e++){f=mb(d[e]);if(0==f.lastIndexOf(c,0))return f.substr(c.length);if(f==a)return""}return b};
m.remove=function(a,b,c){var d=void 0!==this.get(a);this.set(a,"",{Ca:0,path:b,domain:c});return d};
m.isEmpty=function(){return!this.h.cookie};
m.clear=function(){for(var a=(this.h.cookie||"").split(";"),b=[],c=[],d,e,f=0;f<a.length;f++)e=mb(a[f]),d=e.indexOf("="),-1==d?(b.push(""),c.push(e)):(b.push(e.substring(0,d)),c.push(e.substring(d+1)));for(a=b.length-1;0<=a;a--)this.remove(b[a])};
var fd=new ed("undefined"==typeof document?null:document);function gd(a){return!!dd.FPA_SAMESITE_PHASE2_MOD||!(void 0===a||!a)}
function hd(a,b,c,d){(a=B[a])||(a=(new ed(document)).get(b));return a?ad(a,c,d):null}
function id(a){var b=void 0===b?!1:b;var c=Zc(String(B.location.href)),d=[];var e=b;e=void 0===e?!1:e;var f=B.__SAPISID||B.__APISID||B.__3PSAPISID||B.__OVERRIDE_SID;gd(e)&&(f=f||B.__1PSAPISID);if(f)e=!0;else{var g=new ed(document);f=g.get("SAPISID")||g.get("APISID")||g.get("__Secure-3PAPISID")||g.get("SID");gd(e)&&(f=f||g.get("__Secure-1PAPISID"));e=!!f}e&&(e=(c=0==c.indexOf("https:")||0==c.indexOf("chrome-extension:")||0==c.indexOf("moz-extension:"))?B.__SAPISID:B.__APISID,e||(e=new ed(document),
e=e.get(c?"SAPISID":"APISID")||e.get("__Secure-3PAPISID")),(e=e?ad(e,c?"SAPISIDHASH":"APISIDHASH",a):null)&&d.push(e),c&&gd(b)&&((b=hd("__1PSAPISID","__Secure-1PAPISID","SAPISID1PHASH",a))&&d.push(b),(a=hd("__3PSAPISID","__Secure-3PAPISID","SAPISID3PHASH",a))&&d.push(a)));return 0==d.length?null:d.join(" ")}
;function jd(a){a&&"function"==typeof a.dispose&&a.dispose()}
;function kd(){this.l=this.l;this.v=this.v}
kd.prototype.l=!1;kd.prototype.dispose=function(){this.l||(this.l=!0,this.ea())};
kd.prototype.ea=function(){if(this.v)for(;this.v.length;)this.v.shift()()};function ld(a,b){this.type=a;this.h=this.target=b;this.defaultPrevented=this.j=!1}
ld.prototype.stopPropagation=function(){this.j=!0};
ld.prototype.preventDefault=function(){this.defaultPrevented=!0};function md(a){var b=C("window.location.href");null==a&&(a='Unknown Error of type "null/undefined"');if("string"===typeof a)return{message:a,name:"Unknown error",lineNumber:"Not available",fileName:b,stack:"Not available"};var c=!1;try{var d=a.lineNumber||a.line||"Not available"}catch(g){d="Not available",c=!0}try{var e=a.fileName||a.filename||a.sourceURL||B.$googDebugFname||b}catch(g){e="Not available",c=!0}b=nd(a);if(!(!c&&a.lineNumber&&a.fileName&&a.stack&&a.message&&a.name)){c=a.message;if(null==
c){if(a.constructor&&a.constructor instanceof Function){if(a.constructor.name)c=a.constructor.name;else if(c=a.constructor,od[c])c=od[c];else{c=String(c);if(!od[c]){var f=/function\s+([^\(]+)/m.exec(c);od[c]=f?f[1]:"[Anonymous]"}c=od[c]}c='Unknown Error of type "'+c+'"'}else c="Unknown Error of unknown type";"function"===typeof a.toString&&Object.prototype.toString!==a.toString&&(c+=": "+a.toString())}return{message:c,name:a.name||"UnknownError",lineNumber:d,fileName:e,stack:b||"Not available"}}a.stack=
b;return{message:a.message,name:a.name,lineNumber:a.lineNumber,fileName:a.fileName,stack:a.stack}}
function nd(a,b){b||(b={});b[pd(a)]=!0;var c=a.stack||"";(a=a.hb)&&!b[pd(a)]&&(c+="\nCaused by: ",a.stack&&0==a.stack.indexOf(a.toString())||(c+="string"===typeof a?a:a.message+"\n"),c+=nd(a,b));return c}
function pd(a){var b="";"function"===typeof a.toString&&(b=""+a);return b+a.stack}
var od={};var qd=function(){if(!B.addEventListener||!Object.defineProperty)return!1;var a=!1,b=Object.defineProperty({},"passive",{get:function(){a=!0}});
try{B.addEventListener("test",Ia,b),B.removeEventListener("test",Ia,b)}catch(c){}return a}();function rd(a,b){ld.call(this,a?a.type:"");this.relatedTarget=this.h=this.target=null;this.button=this.screenY=this.screenX=this.clientY=this.clientX=0;this.key="";this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.altKey=this.ctrlKey=!1;this.state=null;this.pointerId=0;this.pointerType="";this.i=null;a&&this.init(a,b)}
F(rd,ld);var sd={2:"touch",3:"pen",4:"mouse"};
rd.prototype.init=function(a,b){var c=this.type=a.type,d=a.changedTouches&&a.changedTouches.length?a.changedTouches[0]:null;this.target=a.target||a.srcElement;this.h=b;if(b=a.relatedTarget){if(Xb){a:{try{Tb(b.nodeName);var e=!0;break a}catch(f){}e=!1}e||(b=null)}}else"mouseover"==c?b=a.fromElement:"mouseout"==c&&(b=a.toElement);this.relatedTarget=b;d?(this.clientX=void 0!==d.clientX?d.clientX:d.pageX,this.clientY=void 0!==d.clientY?d.clientY:d.pageY,this.screenX=d.screenX||0,this.screenY=d.screenY||
0):(this.clientX=void 0!==a.clientX?a.clientX:a.pageX,this.clientY=void 0!==a.clientY?a.clientY:a.pageY,this.screenX=a.screenX||0,this.screenY=a.screenY||0);this.button=a.button;this.keyCode=a.keyCode||0;this.key=a.key||"";this.charCode=a.charCode||("keypress"==c?a.keyCode:0);this.ctrlKey=a.ctrlKey;this.altKey=a.altKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey;this.pointerId=a.pointerId||0;this.pointerType="string"===typeof a.pointerType?a.pointerType:sd[a.pointerType]||"";this.state=a.state;
this.i=a;a.defaultPrevented&&rd.M.preventDefault.call(this)};
rd.prototype.stopPropagation=function(){rd.M.stopPropagation.call(this);this.i.stopPropagation?this.i.stopPropagation():this.i.cancelBubble=!0};
rd.prototype.preventDefault=function(){rd.M.preventDefault.call(this);var a=this.i;a.preventDefault?a.preventDefault():a.returnValue=!1};var td="closure_listenable_"+(1E6*Math.random()|0);var ud=0;function vd(a,b,c,d,e){this.listener=a;this.proxy=null;this.src=b;this.type=c;this.capture=!!d;this.qa=e;this.key=++ud;this.ia=this.ma=!1}
function wd(a){a.ia=!0;a.listener=null;a.proxy=null;a.src=null;a.qa=null}
;function xd(a){this.src=a;this.listeners={};this.h=0}
xd.prototype.add=function(a,b,c,d,e){var f=a.toString();a=this.listeners[f];a||(a=this.listeners[f]=[],this.h++);var g=yd(a,b,d,e);-1<g?(b=a[g],c||(b.ma=!1)):(b=new vd(b,this.src,f,!!d,e),b.ma=c,a.push(b));return b};
xd.prototype.remove=function(a,b,c,d){a=a.toString();if(!(a in this.listeners))return!1;var e=this.listeners[a];b=yd(e,b,c,d);return-1<b?(wd(e[b]),Array.prototype.splice.call(e,b,1),0==e.length&&(delete this.listeners[a],this.h--),!0):!1};
function zd(a,b){var c=b.type;c in a.listeners&&Xa(a.listeners[c],b)&&(wd(b),0==a.listeners[c].length&&(delete a.listeners[c],a.h--))}
function yd(a,b,c,d){for(var e=0;e<a.length;++e){var f=a[e];if(!f.ia&&f.listener==b&&f.capture==!!c&&f.qa==d)return e}return-1}
;var Ad="closure_lm_"+(1E6*Math.random()|0),Bd={},Cd=0;function Dd(a,b,c,d,e){if(d&&d.once)Ed(a,b,c,d,e);else if(Array.isArray(b))for(var f=0;f<b.length;f++)Dd(a,b[f],c,d,e);else c=Fd(c),a&&a[td]?a.X(b,c,D(d)?!!d.capture:!!d,e):Gd(a,b,c,!1,d,e)}
function Gd(a,b,c,d,e,f){if(!b)throw Error("Invalid event type");var g=D(e)?!!e.capture:!!e,h=Hd(a);h||(a[Ad]=h=new xd(a));c=h.add(b,c,d,g,f);if(!c.proxy){d=Jd();c.proxy=d;d.src=a;d.listener=c;if(a.addEventListener)qd||(e=g),void 0===e&&(e=!1),a.addEventListener(b.toString(),d,e);else if(a.attachEvent)a.attachEvent(Kd(b.toString()),d);else if(a.addListener&&a.removeListener)a.addListener(d);else throw Error("addEventListener and attachEvent are unavailable.");Cd++}}
function Jd(){function a(c){return b.call(a.src,a.listener,c)}
var b=Ld;return a}
function Ed(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)Ed(a,b[f],c,d,e);else c=Fd(c),a&&a[td]?a.h.add(String(b),c,!0,D(d)?!!d.capture:!!d,e):Gd(a,b,c,!0,d,e)}
function Md(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)Md(a,b[f],c,d,e);else(d=D(d)?!!d.capture:!!d,c=Fd(c),a&&a[td])?a.h.remove(String(b),c,d,e):a&&(a=Hd(a))&&(b=a.listeners[b.toString()],a=-1,b&&(a=yd(b,c,d,e)),(c=-1<a?b[a]:null)&&Nd(c))}
function Nd(a){if("number"!==typeof a&&a&&!a.ia){var b=a.src;if(b&&b[td])zd(b.h,a);else{var c=a.type,d=a.proxy;b.removeEventListener?b.removeEventListener(c,d,a.capture):b.detachEvent?b.detachEvent(Kd(c),d):b.addListener&&b.removeListener&&b.removeListener(d);Cd--;(c=Hd(b))?(zd(c,a),0==c.h&&(c.src=null,b[Ad]=null)):wd(a)}}}
function Kd(a){return a in Bd?Bd[a]:Bd[a]="on"+a}
function Ld(a,b){if(a.ia)a=!0;else{b=new rd(b,this);var c=a.listener,d=a.qa||a.src;a.ma&&Nd(a);a=c.call(d,b)}return a}
function Hd(a){a=a[Ad];return a instanceof xd?a:null}
var Od="__closure_events_fn_"+(1E9*Math.random()>>>0);function Fd(a){if("function"===typeof a)return a;a[Od]||(a[Od]=function(b){return a.handleEvent(b)});
return a[Od]}
;function I(){kd.call(this);this.h=new xd(this);this.xa=this;this.H=null}
F(I,kd);I.prototype[td]=!0;I.prototype.addEventListener=function(a,b,c,d){Dd(this,a,b,c,d)};
I.prototype.removeEventListener=function(a,b,c,d){Md(this,a,b,c,d)};
function Pd(a,b){var c=a.H;if(c){var d=[];for(var e=1;c;c=c.H)d.push(c),++e}a=a.xa;c=b.type||b;"string"===typeof b?b=new ld(b,a):b instanceof ld?b.target=b.target||a:(e=b,b=new ld(c,a),hb(b,e));e=!0;if(d)for(var f=d.length-1;!b.j&&0<=f;f--){var g=b.h=d[f];e=Qd(g,c,!0,b)&&e}b.j||(g=b.h=a,e=Qd(g,c,!0,b)&&e,b.j||(e=Qd(g,c,!1,b)&&e));if(d)for(f=0;!b.j&&f<d.length;f++)g=b.h=d[f],e=Qd(g,c,!1,b)&&e}
I.prototype.ea=function(){I.M.ea.call(this);if(this.h){var a=this.h,b=0,c;for(c in a.listeners){for(var d=a.listeners[c],e=0;e<d.length;e++)++b,wd(d[e]);delete a.listeners[c];a.h--}}this.H=null};
I.prototype.X=function(a,b,c,d){return this.h.add(String(a),b,!1,c,d)};
function Qd(a,b,c,d){b=a.h.listeners[String(b)];if(!b)return!0;b=b.concat();for(var e=!0,f=0;f<b.length;++f){var g=b[f];if(g&&!g.ia&&g.capture==c){var h=g.listener,k=g.qa||g.src;g.ma&&zd(a.h,g);e=!1!==h.call(k,d)&&e}}return e&&!d.defaultPrevented}
;function Rd(a){var b,c;I.call(this);var d=this;this.A=this.j=0;this.J=null!==a&&void 0!==a?a:{K:function(e,f){return setTimeout(e,f)},
W:clearTimeout};this.i=null!==(c=null===(b=window.navigator)||void 0===b?void 0:b.onLine)&&void 0!==c?c:!0;this.m=function(){return z(function(e){return y(e,Sd(d),0)})};
window.addEventListener("offline",this.m);window.addEventListener("online",this.m);this.A||Td(this)}
w(Rd,I);Rd.prototype.dispose=function(){window.removeEventListener("offline",this.m);window.removeEventListener("online",this.m);this.J.W(this.A);delete Rd.h};
Rd.prototype.D=function(){return this.i};
function Td(a){a.A=a.J.K(function(){var b;return z(function(c){if(1==c.h)return a.i?(null===(b=window.navigator)||void 0===b?0:b.onLine)?c.o(3):y(c,Sd(a),3):y(c,Sd(a),3);Td(a);c.h=0})},3E4)}
function Sd(a,b){return a.u?a.u:a.u=new Promise(function(c){var d,e,f;return z(function(g){switch(g.h){case 1:return d=window.AbortController?new window.AbortController:void 0,e=null===d||void 0===d?void 0:d.signal,f=!1,sa(g,2,3),d&&(a.j=a.J.K(function(){d.abort()},b||2E4)),y(g,fetch("/generate_204",{method:"HEAD",
signal:e}),5);case 5:f=!0;case 3:va(g);a.u=void 0;a.j&&(a.J.W(a.j),a.j=0);f!==a.i&&(a.i=f,a.i?Pd(a,"networkstatus-online"):Pd(a,"networkstatus-offline"));c(f);wa(g);break;case 2:ua(g),f=!1,g.o(3)}})})}
;function Ud(){this.data_=[];this.h=-1}
Ud.prototype.set=function(a,b){b=void 0===b?!0:b;0<=a&&52>a&&0===a%1&&this.data_[a]!=b&&(this.data_[a]=b,this.h=-1)};
Ud.prototype.get=function(a){return!!this.data_[a]};
function Vd(a){-1==a.h&&(a.h=Wa(a.data_,function(b,c,d){return c?b+Math.pow(2,d):b},0));
return a.h}
;function Wd(a,b){this.j=a;this.l=b;this.i=0;this.h=null}
Wd.prototype.get=function(){if(0<this.i){this.i--;var a=this.h;this.h=a.next;a.next=null}else a=this.j();return a};
function Xd(a,b){a.l(b);100>a.i&&(a.i++,b.next=a.h,a.h=b)}
;var Yd;
function Zd(){var a=B.MessageChannel;"undefined"===typeof a&&"undefined"!==typeof window&&window.postMessage&&window.addEventListener&&!H("Presto")&&(a=function(){var e=Pc(document,"IFRAME");e.style.display="none";document.documentElement.appendChild(e);var f=e.contentWindow;e=f.document;e.open();e.close();var g="callImmediate"+Math.random(),h="file:"==f.location.protocol?"*":f.location.protocol+"//"+f.location.host;e=Qa(function(k){if(("*"==h||k.origin==h)&&k.data==g)this.port1.onmessage()},this);
f.addEventListener("message",e,!1);this.port1={};this.port2={postMessage:function(){f.postMessage(g,h)}}});
if("undefined"!==typeof a&&!H("Trident")&&!H("MSIE")){var b=new a,c={},d=c;b.port1.onmessage=function(){if(void 0!==c.next){c=c.next;var e=c.Ka;c.Ka=null;e()}};
return function(e){d.next={Ka:e};d=d.next;b.port2.postMessage(0)}}return function(e){B.setTimeout(e,0)}}
;function $d(){this.i=this.h=null}
$d.prototype.add=function(a,b){var c=ae.get();c.set(a,b);this.i?this.i.next=c:this.h=c;this.i=c};
$d.prototype.remove=function(){var a=null;this.h&&(a=this.h,this.h=this.h.next,this.h||(this.i=null),a.next=null);return a};
var ae=new Wd(function(){return new be},function(a){return a.reset()});
function be(){this.next=this.scope=this.h=null}
be.prototype.set=function(a,b){this.h=a;this.scope=b;this.next=null};
be.prototype.reset=function(){this.next=this.scope=this.h=null};function ce(a,b){de||ee();fe||(de(),fe=!0);ge.add(a,b)}
var de;function ee(){if(B.Promise&&B.Promise.resolve){var a=B.Promise.resolve(void 0);de=function(){a.then(he)}}else de=function(){var b=he;
"function"!==typeof B.setImmediate||B.Window&&B.Window.prototype&&!H("Edge")&&B.Window.prototype.setImmediate==B.setImmediate?(Yd||(Yd=Zd()),Yd(b)):B.setImmediate(b)}}
var fe=!1,ge=new $d;function he(){for(var a;a=ge.remove();){try{a.h.call(a.scope)}catch(b){Rb(b)}Xd(ae,a)}fe=!1}
;function ie(a,b){this.h=a[B.Symbol.iterator]();this.i=b;this.j=0}
ie.prototype[Symbol.iterator]=function(){return this};
ie.prototype.next=function(){var a=this.h.next();return{value:a.done?void 0:this.i.call(void 0,a.value,this.j++),done:a.done}};
function je(a,b){return new ie(a,b)}
;function ke(){this.blockSize=-1}
;function le(){this.blockSize=-1;this.blockSize=64;this.h=[];this.m=[];this.v=[];this.j=[];this.j[0]=128;for(var a=1;a<this.blockSize;++a)this.j[a]=0;this.l=this.i=0;this.reset()}
F(le,ke);le.prototype.reset=function(){this.h[0]=1732584193;this.h[1]=4023233417;this.h[2]=2562383102;this.h[3]=271733878;this.h[4]=3285377520;this.l=this.i=0};
function me(a,b,c){c||(c=0);var d=a.v;if("string"===typeof b)for(var e=0;16>e;e++)d[e]=b.charCodeAt(c)<<24|b.charCodeAt(c+1)<<16|b.charCodeAt(c+2)<<8|b.charCodeAt(c+3),c+=4;else for(e=0;16>e;e++)d[e]=b[c]<<24|b[c+1]<<16|b[c+2]<<8|b[c+3],c+=4;for(e=16;80>e;e++){var f=d[e-3]^d[e-8]^d[e-14]^d[e-16];d[e]=(f<<1|f>>>31)&4294967295}b=a.h[0];c=a.h[1];var g=a.h[2],h=a.h[3],k=a.h[4];for(e=0;80>e;e++){if(40>e)if(20>e){f=h^c&(g^h);var l=1518500249}else f=c^g^h,l=1859775393;else 60>e?(f=c&g|h&(c|g),l=2400959708):
(f=c^g^h,l=3395469782);f=(b<<5|b>>>27)+f+k+l+d[e]&4294967295;k=h;h=g;g=(c<<30|c>>>2)&4294967295;c=b;b=f}a.h[0]=a.h[0]+b&4294967295;a.h[1]=a.h[1]+c&4294967295;a.h[2]=a.h[2]+g&4294967295;a.h[3]=a.h[3]+h&4294967295;a.h[4]=a.h[4]+k&4294967295}
le.prototype.update=function(a,b){if(null!=a){void 0===b&&(b=a.length);for(var c=b-this.blockSize,d=0,e=this.m,f=this.i;d<b;){if(0==f)for(;d<=c;)me(this,a,d),d+=this.blockSize;if("string"===typeof a)for(;d<b;){if(e[f]=a.charCodeAt(d),++f,++d,f==this.blockSize){me(this,e);f=0;break}}else for(;d<b;)if(e[f]=a[d],++f,++d,f==this.blockSize){me(this,e);f=0;break}}this.i=f;this.l+=b}};
le.prototype.digest=function(){var a=[],b=8*this.l;56>this.i?this.update(this.j,56-this.i):this.update(this.j,this.blockSize-(this.i-56));for(var c=this.blockSize-1;56<=c;c--)this.m[c]=b&255,b/=256;me(this,this.m);for(c=b=0;5>c;c++)for(var d=24;0<=d;d-=8)a[b]=this.h[c]>>d&255,++b;return a};var ne="StopIteration"in B?B.StopIteration:{message:"StopIteration",stack:""};function oe(){}
oe.prototype.O=function(){throw ne;};
oe.prototype.next=function(){return pe};
var pe={done:!0,value:void 0};function qe(a){return{value:a,done:!1}}
function re(a){if(a.done)throw ne;return a.value}
oe.prototype.I=function(){return this};function se(a){if(a instanceof te||a instanceof ue||a instanceof ve)return a;if("function"==typeof a.O)return new te(function(){return we(a)});
if("function"==typeof a[Symbol.iterator])return new te(function(){return a[Symbol.iterator]()});
if("function"==typeof a.I)return new te(function(){return we(a.I())});
throw Error("Not an iterator or iterable.");}
function we(a){if(!(a instanceof oe))return a;var b=!1;return{next:function(){for(var c;!b;)try{c=a.O();break}catch(d){if(d!==ne)throw d;b=!0}return{value:c,done:b}}}}
function te(a){this.h=a}
te.prototype.I=function(){return new ue(this.h())};
te.prototype[Symbol.iterator]=function(){return new ve(this.h())};
te.prototype.i=function(){return new ve(this.h())};
function ue(a){this.h=a}
w(ue,oe);ue.prototype.O=function(){var a=this.h.next();if(a.done)throw ne;return a.value};
ue.prototype.next=function(){return this.h.next()};
ue.prototype[Symbol.iterator]=function(){return new ve(this.h)};
ue.prototype.i=function(){return new ve(this.h)};
function ve(a){te.call(this,function(){return a});
this.j=a}
w(ve,te);ve.prototype.next=function(){return this.j.next()};function xe(a,b){this.i={};this.h=[];this.j=this.size=0;var c=arguments.length;if(1<c){if(c%2)throw Error("Uneven number of arguments");for(var d=0;d<c;d+=2)this.set(arguments[d],arguments[d+1])}else if(a)if(a instanceof xe)for(c=ye(a),d=0;d<c.length;d++)this.set(c[d],a.get(c[d]));else for(d in a)this.set(d,a[d])}
function ye(a){ze(a);return a.h.concat()}
m=xe.prototype;m.has=function(a){return Ae(this.i,a)};
m.equals=function(a,b){if(this===a)return!0;if(this.size!=a.size)return!1;b=b||Be;ze(this);for(var c,d=0;c=this.h[d];d++)if(!b(this.get(c),a.get(c)))return!1;return!0};
function Be(a,b){return a===b}
m.isEmpty=function(){return 0==this.size};
m.clear=function(){this.i={};this.j=this.size=this.h.length=0};
m.remove=function(a){return this.delete(a)};
m.delete=function(a){return Ae(this.i,a)?(delete this.i[a],--this.size,this.j++,this.h.length>2*this.size&&ze(this),!0):!1};
function ze(a){if(a.size!=a.h.length){for(var b=0,c=0;b<a.h.length;){var d=a.h[b];Ae(a.i,d)&&(a.h[c++]=d);b++}a.h.length=c}if(a.size!=a.h.length){var e={};for(c=b=0;b<a.h.length;)d=a.h[b],Ae(e,d)||(a.h[c++]=d,e[d]=1),b++;a.h.length=c}}
m.get=function(a,b){return Ae(this.i,a)?this.i[a]:b};
m.set=function(a,b){Ae(this.i,a)||(this.size+=1,this.h.push(a),this.j++);this.i[a]=b};
m.forEach=function(a,b){for(var c=ye(this),d=0;d<c.length;d++){var e=c[d],f=this.get(e);a.call(b,f,e,this)}};
m.clone=function(){return new xe(this)};
m.keys=function(){return se(this.I(!0)).i()};
m.values=function(){return se(this.I(!1)).i()};
m.entries=function(){var a=this;return je(this.keys(),function(b){return[b,a.get(b)]})};
m.I=function(a){ze(this);var b=0,c=this.j,d=this,e=new oe;e.next=function(){if(c!=d.j)throw Error("The map has changed since the iterator was created");if(b>=d.h.length)return pe;var g=d.h[b++];return qe(a?g:d.i[g])};
var f=e.next;e.O=function(){return re(f.call(e))};
return e};
function Ae(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
;var Ce=B.JSON.stringify;function De(a){this.h=0;this.u=void 0;this.l=this.i=this.j=null;this.m=this.v=!1;if(a!=Ia)try{var b=this;a.call(void 0,function(c){Ee(b,2,c)},function(c){Ee(b,3,c)})}catch(c){Ee(this,3,c)}}
function Fe(){this.next=this.context=this.onRejected=this.i=this.h=null;this.j=!1}
Fe.prototype.reset=function(){this.context=this.onRejected=this.i=this.h=null;this.j=!1};
var Ge=new Wd(function(){return new Fe},function(a){a.reset()});
function He(a,b,c){var d=Ge.get();d.i=a;d.onRejected=b;d.context=c;return d}
De.prototype.then=function(a,b,c){return Ie(this,"function"===typeof a?a:null,"function"===typeof b?b:null,c)};
De.prototype.$goog_Thenable=!0;De.prototype.cancel=function(a){if(0==this.h){var b=new Je(a);ce(function(){Ke(this,b)},this)}};
function Ke(a,b){if(0==a.h)if(a.j){var c=a.j;if(c.i){for(var d=0,e=null,f=null,g=c.i;g&&(g.j||(d++,g.h==a&&(e=g),!(e&&1<d)));g=g.next)e||(f=g);e&&(0==c.h&&1==d?Ke(c,b):(f?(d=f,d.next==c.l&&(c.l=d),d.next=d.next.next):Le(c),Me(c,e,3,b)))}a.j=null}else Ee(a,3,b)}
function Ne(a,b){a.i||2!=a.h&&3!=a.h||Oe(a);a.l?a.l.next=b:a.i=b;a.l=b}
function Ie(a,b,c,d){var e=He(null,null,null);e.h=new De(function(f,g){e.i=b?function(h){try{var k=b.call(d,h);f(k)}catch(l){g(l)}}:f;
e.onRejected=c?function(h){try{var k=c.call(d,h);void 0===k&&h instanceof Je?g(h):f(k)}catch(l){g(l)}}:g});
e.h.j=a;Ne(a,e);return e.h}
De.prototype.H=function(a){this.h=0;Ee(this,2,a)};
De.prototype.N=function(a){this.h=0;Ee(this,3,a)};
function Ee(a,b,c){if(0==a.h){a===c&&(b=3,c=new TypeError("Promise cannot resolve to itself"));a.h=1;a:{var d=c,e=a.H,f=a.N;if(d instanceof De){Ne(d,He(e||Ia,f||null,a));var g=!0}else{if(d)try{var h=!!d.$goog_Thenable}catch(l){h=!1}else h=!1;if(h)d.then(e,f,a),g=!0;else{if(D(d))try{var k=d.then;if("function"===typeof k){Pe(d,k,e,f,a);g=!0;break a}}catch(l){f.call(a,l);g=!0;break a}g=!1}}}g||(a.u=c,a.h=b,a.j=null,Oe(a),3!=b||c instanceof Je||Qe(a,c))}}
function Pe(a,b,c,d,e){function f(k){h||(h=!0,d.call(e,k))}
function g(k){h||(h=!0,c.call(e,k))}
var h=!1;try{b.call(a,g,f)}catch(k){f(k)}}
function Oe(a){a.v||(a.v=!0,ce(a.A,a))}
function Le(a){var b=null;a.i&&(b=a.i,a.i=b.next,b.next=null);a.i||(a.l=null);return b}
De.prototype.A=function(){for(var a;a=Le(this);)Me(this,a,this.h,this.u);this.v=!1};
function Me(a,b,c,d){if(3==c&&b.onRejected&&!b.j)for(;a&&a.m;a=a.j)a.m=!1;if(b.h)b.h.j=null,Re(b,c,d);else try{b.j?b.i.call(b.context):Re(b,c,d)}catch(e){Se.call(null,e)}Xd(Ge,b)}
function Re(a,b,c){2==b?a.i.call(a.context,c):a.onRejected&&a.onRejected.call(a.context,c)}
function Qe(a,b){a.m=!0;ce(function(){a.m&&Se.call(null,b)})}
var Se=Rb;function Je(a){Sa.call(this,a)}
F(Je,Sa);Je.prototype.name="cancel";function L(a){kd.call(this);this.u=1;this.j=[];this.m=0;this.h=[];this.i={};this.A=!!a}
F(L,kd);m=L.prototype;m.subscribe=function(a,b,c){var d=this.i[a];d||(d=this.i[a]=[]);var e=this.u;this.h[e]=a;this.h[e+1]=b;this.h[e+2]=c;this.u=e+3;d.push(e);return e};
function Te(a,b,c){var d=Ue;if(a=d.i[a]){var e=d.h;(a=a.find(function(f){return e[f+1]==b&&e[f+2]==c}))&&d.ka(a)}}
m.ka=function(a){var b=this.h[a];if(b){var c=this.i[b];0!=this.m?(this.j.push(a),this.h[a+1]=Ia):(c&&Xa(c,a),delete this.h[a],delete this.h[a+1],delete this.h[a+2])}return!!b};
m.ba=function(a,b){var c=this.i[a];if(c){for(var d=Array(arguments.length-1),e=1,f=arguments.length;e<f;e++)d[e-1]=arguments[e];if(this.A)for(e=0;e<c.length;e++){var g=c[e];Ve(this.h[g+1],this.h[g+2],d)}else{this.m++;try{for(e=0,f=c.length;e<f&&!this.l;e++)g=c[e],this.h[g+1].apply(this.h[g+2],d)}finally{if(this.m--,0<this.j.length&&0==this.m)for(;c=this.j.pop();)this.ka(c)}}return 0!=e}return!1};
function Ve(a,b,c){ce(function(){a.apply(b,c)})}
m.clear=function(a){if(a){var b=this.i[a];b&&(b.forEach(this.ka,this),delete this.i[a])}else this.h.length=0,this.i={}};
m.ea=function(){L.M.ea.call(this);this.clear();this.j.length=0};function We(a){this.h=a}
We.prototype.set=function(a,b){void 0===b?this.h.remove(a):this.h.set(a,Ce(b))};
We.prototype.get=function(a){try{var b=this.h.get(a)}catch(c){return}if(null!==b)try{return JSON.parse(b)}catch(c){throw"Storage: Invalid value was encountered";}};
We.prototype.remove=function(a){this.h.remove(a)};function Xe(a){this.h=a}
F(Xe,We);function Ye(a){this.data=a}
function Ze(a){return void 0===a||a instanceof Ye?a:new Ye(a)}
Xe.prototype.set=function(a,b){Xe.M.set.call(this,a,Ze(b))};
Xe.prototype.i=function(a){a=Xe.M.get.call(this,a);if(void 0===a||a instanceof Object)return a;throw"Storage: Invalid value was encountered";};
Xe.prototype.get=function(a){if(a=this.i(a)){if(a=a.data,void 0===a)throw"Storage: Invalid value was encountered";}else a=void 0;return a};function $e(a){this.h=a}
F($e,Xe);$e.prototype.set=function(a,b,c){if(b=Ze(b)){if(c){if(c<Date.now()){$e.prototype.remove.call(this,a);return}b.expiration=c}b.creation=Date.now()}$e.M.set.call(this,a,b)};
$e.prototype.i=function(a){var b=$e.M.i.call(this,a);if(b){var c=b.creation,d=b.expiration;if(d&&d<Date.now()||c&&c>Date.now())$e.prototype.remove.call(this,a);else return b}};function af(){}
;function bf(){}
F(bf,af);bf.prototype[Symbol.iterator]=function(){return se(this.I(!0)).i()};
bf.prototype.clear=function(){var a=Array.from(this);a=t(a);for(var b=a.next();!b.done;b=a.next())this.remove(b.value)};function cf(a){this.h=a}
F(cf,bf);m=cf.prototype;m.isAvailable=function(){if(!this.h)return!1;try{return this.h.setItem("__sak","1"),this.h.removeItem("__sak"),!0}catch(a){return!1}};
m.set=function(a,b){try{this.h.setItem(a,b)}catch(c){if(0==this.h.length)throw"Storage mechanism: Storage disabled";throw"Storage mechanism: Quota exceeded";}};
m.get=function(a){a=this.h.getItem(a);if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
m.remove=function(a){this.h.removeItem(a)};
m.I=function(a){var b=0,c=this.h,d=new oe;d.next=function(){if(b>=c.length)return pe;var f=c.key(b++);if(a)return qe(f);f=c.getItem(f);if("string"!==typeof f)throw"Storage mechanism: Invalid value was encountered";return qe(f)};
var e=d.next;d.O=function(){return re(e.call(d))};
return d};
m.clear=function(){this.h.clear()};
m.key=function(a){return this.h.key(a)};function df(){var a=null;try{a=window.localStorage||null}catch(b){}this.h=a}
F(df,cf);function ef(a,b){this.i=a;this.h=null;var c;if(c=Vb)c=!(9<=Number(gc));if(c){ff||(ff=new xe);this.h=ff.get(a);this.h||(b?this.h=document.getElementById(b):(this.h=document.createElement("userdata"),this.h.addBehavior("#default#userData"),document.body.appendChild(this.h)),ff.set(a,this.h));try{this.h.load(this.i)}catch(d){this.h=null}}}
F(ef,bf);var gf={".":".2E","!":".21","~":".7E","*":".2A","'":".27","(":".28",")":".29","%":"."},ff=null;function hf(a){return"_"+encodeURIComponent(a).replace(/[.!~*'()%]/g,function(b){return gf[b]})}
m=ef.prototype;m.isAvailable=function(){return!!this.h};
m.set=function(a,b){this.h.setAttribute(hf(a),b);jf(this)};
m.get=function(a){a=this.h.getAttribute(hf(a));if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
m.remove=function(a){this.h.removeAttribute(hf(a));jf(this)};
m.I=function(a){var b=0,c=this.h.XMLDocument.documentElement.attributes,d=new oe;d.next=function(){if(b>=c.length)return pe;var f=c[b++];if(a)return qe(decodeURIComponent(f.nodeName.replace(/\./g,"%")).substr(1));f=f.nodeValue;if("string"!==typeof f)throw"Storage mechanism: Invalid value was encountered";return qe(f)};
var e=d.next;d.O=function(){return re(e.call(d))};
return d};
m.clear=function(){for(var a=this.h.XMLDocument.documentElement,b=a.attributes.length;0<b;b--)a.removeAttribute(a.attributes[b-1].nodeName);jf(this)};
function jf(a){try{a.h.save(a.i)}catch(b){throw"Storage mechanism: Quota exceeded";}}
;function kf(a,b){this.i=a;this.h=b+"::"}
F(kf,bf);kf.prototype.set=function(a,b){this.i.set(this.h+a,b)};
kf.prototype.get=function(a){return this.i.get(this.h+a)};
kf.prototype.remove=function(a){this.i.remove(this.h+a)};
kf.prototype.I=function(a){var b=this.i.I(!0),c=this,d=new oe;d.next=function(){try{var f=b.O()}catch(g){if(g===ne)return pe;throw g;}for(;f.substr(0,c.h.length)!=c.h;)try{f=b.O()}catch(g){if(g===ne)return pe;throw g;}return qe(a?f.substr(c.h.length):c.i.get(f))};
var e=d.next;d.O=function(){return re(e.call(d))};
return d};function lf(a){Bc.call(this,a)}
w(lf,Bc);var mf,nf,of,pf=B.window,qf=(null===(mf=null===pf||void 0===pf?void 0:pf.yt)||void 0===mf?void 0:mf.config_)||(null===(nf=null===pf||void 0===pf?void 0:pf.ytcfg)||void 0===nf?void 0:nf.data_)||{},rf=(null===(of=null===pf||void 0===pf?void 0:pf.ytcfg)||void 0===of?void 0:of.obfuscatedData_)||[];function sf(){lf.apply(this,arguments)}
w(sf,lf);new sf(rf);E("yt.config_",qf);E("yt.configJspb_",rf);function tf(){var a=arguments;1<a.length?qf[a[0]]=a[1]:1===a.length&&Object.assign(qf,a[0])}
function N(a,b){return a in qf?qf[a]:b}
function uf(){return N("LATEST_ECATCHER_SERVICE_TRACKING_PARAMS",void 0)}
;var vf=[];function wf(a){vf.forEach(function(b){return b(a)})}
function xf(a){return a&&window.yterr?function(){try{return a.apply(this,arguments)}catch(b){yf(b)}}:a}
function yf(a,b,c,d){var e=C("yt.logging.errors.log");e?e(a,"ERROR",b,c,d):(e=N("ERRORS",[]),e.push([a,"ERROR",b,c,d]),tf("ERRORS",e));wf(a)}
function zf(a,b,c,d){var e=C("yt.logging.errors.log");e?e(a,"WARNING",b,c,d):(e=N("ERRORS",[]),e.push([a,"WARNING",b,c,d]),tf("ERRORS",e))}
;var Af=0;E("ytDomDomGetNextId",C("ytDomDomGetNextId")||function(){return++Af});var Bf={stopImmediatePropagation:1,stopPropagation:1,preventMouseEvent:1,preventManipulation:1,preventDefault:1,layerX:1,layerY:1,screenX:1,screenY:1,scale:1,rotation:1,webkitMovementX:1,webkitMovementY:1};
function Cf(a){this.type="";this.state=this.source=this.data=this.currentTarget=this.relatedTarget=this.target=null;this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.ctrlKey=this.altKey=!1;this.rotation=this.clientY=this.clientX=0;this.scale=1;this.changedTouches=this.touches=null;try{if(a=a||window.event){this.event=a;for(var b in a)b in Bf||(this[b]=a[b]);this.scale=a.scale;this.rotation=a.rotation;var c=a.target||a.srcElement;c&&3==c.nodeType&&(c=c.parentNode);this.target=c;var d=a.relatedTarget;
if(d)try{d=d.nodeName?d:null}catch(e){d=null}else"mouseover"==this.type?d=a.fromElement:"mouseout"==this.type&&(d=a.toElement);this.relatedTarget=d;this.clientX=void 0!=a.clientX?a.clientX:a.pageX;this.clientY=void 0!=a.clientY?a.clientY:a.pageY;this.keyCode=a.keyCode?a.keyCode:a.which;this.charCode=a.charCode||("keypress"==this.type?this.keyCode:0);this.altKey=a.altKey;this.ctrlKey=a.ctrlKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey}}catch(e){}}
Cf.prototype.preventDefault=function(){this.event&&(this.event.returnValue=!1,this.event.preventDefault&&this.event.preventDefault())};
Cf.prototype.stopPropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopPropagation&&this.event.stopPropagation())};
Cf.prototype.stopImmediatePropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopImmediatePropagation&&this.event.stopImmediatePropagation())};var db=B.ytEventsEventsListeners||{};E("ytEventsEventsListeners",db);var Df=B.ytEventsEventsCounter||{count:0};E("ytEventsEventsCounter",Df);
function Ef(a,b,c,d){d=void 0===d?{}:d;a.addEventListener&&("mouseenter"!=b||"onmouseenter"in document?"mouseleave"!=b||"onmouseenter"in document?"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"):b="mouseout":b="mouseover");return bb(function(e){var f="boolean"===typeof e[4]&&e[4]==!!d,g=D(e[4])&&D(d)&&eb(e[4],d);return!!e.length&&e[0]==a&&e[1]==b&&e[2]==c&&(f||g)})}
function Ff(a){a&&("string"==typeof a&&(a=[a]),G(a,function(b){if(b in db){var c=db[b],d=c[0],e=c[1],f=c[3];c=c[4];d.removeEventListener?Gf()||"boolean"===typeof c?d.removeEventListener(e,f,c):d.removeEventListener(e,f,!!c.capture):d.detachEvent&&d.detachEvent("on"+e,f);delete db[b]}}))}
var Gf=Ua(function(){var a=!1;try{var b=Object.defineProperty({},"capture",{get:function(){a=!0}});
window.addEventListener("test",null,b)}catch(c){}return a});
function Hf(a,b,c){var d=void 0===d?{}:d;if(a&&(a.addEventListener||a.attachEvent)){var e=Ef(a,b,c,d);if(!e){e=++Df.count+"";var f=!("mouseenter"!=b&&"mouseleave"!=b||!a.addEventListener||"onmouseenter"in document);var g=f?function(h){h=new Cf(h);if(!Rc(h.relatedTarget,function(k){return k==a}))return h.currentTarget=a,h.type=b,c.call(a,h)}:function(h){h=new Cf(h);
h.currentTarget=a;return c.call(a,h)};
g=xf(g);a.addEventListener?("mouseenter"==b&&f?b="mouseover":"mouseleave"==b&&f?b="mouseout":"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"),Gf()||"boolean"===typeof d?a.addEventListener(b,g,d):a.addEventListener(b,g,!!d.capture)):a.attachEvent("on"+b,g);db[e]=[a,b,c,g,d]}}}
;function If(a,b){"function"===typeof a&&(a=xf(a));return window.setTimeout(a,b)}
function Jf(a){"function"===typeof a&&(a=xf(a));return window.setInterval(a,250)}
;var Kf=/^[\w.]*$/,Lf={q:!0,search_query:!0};function Mf(a,b){b=a.split(b);for(var c={},d=0,e=b.length;d<e;d++){var f=b[d].split("=");if(1==f.length&&f[0]||2==f.length)try{var g=Nf(f[0]||""),h=Nf(f[1]||"");g in c?Array.isArray(c[g])?$a(c[g],h):c[g]=[c[g],h]:c[g]=h}catch(p){var k=p,l=f[0],n=String(Mf);k.args=[{key:l,value:f[1],query:a,method:Of==n?"unchanged":n}];Lf.hasOwnProperty(l)||zf(k)}}return c}
var Of=String(Mf);function Pf(a){var b=[];ab(a,function(c,d){var e=encodeURIComponent(String(d)),f;Array.isArray(c)?f=c:f=[c];G(f,function(g){""==g?b.push(e):b.push(e+"="+encodeURIComponent(String(g)))})});
return b.join("&")}
function Qf(a){"?"==a.charAt(0)&&(a=a.substr(1));return Mf(a,"&")}
function Rf(a,b,c){var d=a.split("#",2);a=d[0];d=1<d.length?"#"+d[1]:"";var e=a.split("?",2);a=e[0];e=Qf(e[1]||"");for(var f in b)!c&&null!==e&&f in e||(e[f]=b[f]);b=a;a=Ob(e);a?(c=b.indexOf("#"),0>c&&(c=b.length),f=b.indexOf("?"),0>f||f>c?(f=c,e=""):e=b.substring(f+1,c),b=[b.substr(0,f),e,b.substr(c)],c=b[1],b[1]=a?c?c+"&"+a:a:c,a=b[0]+(b[1]?"?"+b[1]:"")+b[2]):a=b;return a+d}
function Sf(a){if(!b)var b=window.location.href;var c=a.match(Jb)[1]||null,d=Lb(a);c&&d?(a=a.match(Jb),b=b.match(Jb),a=a[3]==b[3]&&a[1]==b[1]&&a[4]==b[4]):a=d?Lb(b)==d&&(Number(b.match(Jb)[4]||null)||null)==(Number(a.match(Jb)[4]||null)||null):!0;return a}
function Nf(a){return a&&a.match(Kf)?a:decodeURIComponent(a.replace(/\+/g," "))}
;function O(a){a=Tf(a);return"string"===typeof a&&"false"===a?!1:!!a}
function Uf(a,b){a=Tf(a);return void 0===a&&void 0!==b?b:Number(a||0)}
function Tf(a){var b=N("EXPERIMENTS_FORCED_FLAGS",{});return void 0!==b[a]?b[a]:N("EXPERIMENT_FLAGS",{})[a]}
;var Vf={appSettingsCaptured:!0,visualElementAttached:!0,visualElementGestured:!0,visualElementHidden:!0,visualElementShown:!0,flowEvent:!0,visualElementStateChanged:!0,playbackAssociated:!0,youThere:!0,accountStateChangeSignedIn:!0,accountStateChangeSignedOut:!0},Wf={latencyActionBaselined:!0,latencyActionInfo:!0,latencyActionTicked:!0,bedrockRepetitiveActionTimed:!0,adsClientStateChange:!0,streamzIncremented:!0,mdxDialAdditionalDataUpdateEvent:!0,tvhtml5WatchKeyEvent:!0,tvhtml5VideoSeek:!0,tokenRefreshEvent:!0,
adNotify:!0,adNotifyFilled:!0,tvhtml5LaunchUrlComponentChanged:!0,bedrockResourceConsumptionSnapshot:!0,deviceStartupMetrics:!0,mdxSignIn:!0,tvhtml5KeyboardLogging:!0,tvhtml5StartupSoundEvent:!0,tvhtml5LiveChatStatus:!0,tvhtml5DeviceStorageStatus:!0,tvhtml5LocalStorage:!0,directSignInEvent:!0,finalPayload:!0,tvhtml5SearchCompleted:!0,tvhtml5KeyboardPerformance:!0,adNotifyFailure:!0,latencyActionSpan:!0,tvhtml5AccountDialogOpened:!0,tvhtml5ApiTest:!0};function Xf(){}
function Yf(a,b){return Zf(a,0,b)}
Xf.prototype.K=function(a,b){return Zf(a,1,b)};
function $f(a,b){Zf(a,2,b)}
;function ag(){Xf.apply(this,arguments)}
w(ag,Xf);function bg(){ag.h||(ag.h=new ag);return ag.h}
function Zf(a,b,c){void 0!==c&&Number.isNaN(Number(c))&&(c=void 0);var d=C("yt.scheduler.instance.addJob");return d?d(a,b,c):void 0===c?(a(),NaN):If(a,c||0)}
ag.prototype.W=function(a){if(void 0===a||!Number.isNaN(Number(a))){var b=C("yt.scheduler.instance.cancelJob");b?b(a):window.clearTimeout(a)}};
ag.prototype.start=function(){var a=C("yt.scheduler.instance.start");a&&a()};var cg=bg();function dg(a){var b=eg;a=void 0===a?C("yt.ads.biscotti.lastId_")||"":a;var c=Object,d=c.assign,e={};e.dt=Yc;e.flash="0";a:{try{var f=b.h.top.location.href}catch(qa){f=2;break a}f=f?f===b.i.location.href?0:1:2}e=(e.frm=f,e);try{e.u_tz=-(new Date).getTimezoneOffset();var g=void 0===g?Kc:g;try{var h=g.history.length}catch(qa){h=0}e.u_his=h;var k;e.u_h=null==(k=Kc.screen)?void 0:k.height;var l;e.u_w=null==(l=Kc.screen)?void 0:l.width;var n;e.u_ah=null==(n=Kc.screen)?void 0:n.availHeight;var p;e.u_aw=
null==(p=Kc.screen)?void 0:p.availWidth;var u;e.u_cd=null==(u=Kc.screen)?void 0:u.colorDepth}catch(qa){}h=b.h;try{var q=h.screenX;var v=h.screenY}catch(qa){}try{var x=h.outerWidth;var A=h.outerHeight}catch(qa){}try{var J=h.innerWidth;var K=h.innerHeight}catch(qa){}try{var M=h.screenLeft;var Cb=h.screenTop}catch(qa){}try{J=h.innerWidth,K=h.innerHeight}catch(qa){}try{var Id=h.screen.availWidth;var gj=h.screen.availTop}catch(qa){}q=[M,Cb,q,v,Id,gj,x,A,J,K];v=b.h.top;try{var cb=(v||window).document,Z=
"CSS1Compat"==cb.compatMode?cb.documentElement:cb.body;var ea=(new Lc(Z.clientWidth,Z.clientHeight)).round()}catch(qa){ea=new Lc(-12245933,-12245933)}cb=ea;ea={};Z=new Ud;B.SVGElement&&B.document.createElementNS&&Z.set(0);v=Wc();v["allow-top-navigation-by-user-activation"]&&Z.set(1);v["allow-popups-to-escape-sandbox"]&&Z.set(2);B.crypto&&B.crypto.subtle&&Z.set(3);B.TextDecoder&&B.TextEncoder&&Z.set(4);Z=Vd(Z);ea.bc=Z;ea.bih=cb.height;ea.biw=cb.width;ea.brdim=q.join();b=b.i;b=(ea.vis={visible:1,hidden:2,
prerender:3,preview:4,unloaded:5}[b.visibilityState||b.webkitVisibilityState||b.mozVisibilityState||""]||0,ea.wgl=!!Kc.WebGLRenderingContext,ea);c=d.call(c,e,b);c.ca_type="image";a&&(c.bid=a);return c}
var eg=new function(){var a=window.document;this.h=window;this.i=a};
E("yt.ads_.signals_.getAdSignalsString",function(a){return Pf(dg(a))});Date.now();var fg="XMLHttpRequest"in B?function(){return new XMLHttpRequest}:null;
function gg(){if(!fg)return null;var a=fg();return"open"in a?a:null}
;var hg={Authorization:"AUTHORIZATION","X-Goog-Visitor-Id":"SANDBOXED_VISITOR_ID","X-Youtube-Domain-Admin-State":"DOMAIN_ADMIN_STATE","X-Youtube-Chrome-Connected":"CHROME_CONNECTED_HEADER","X-YouTube-Client-Name":"INNERTUBE_CONTEXT_CLIENT_NAME","X-YouTube-Client-Version":"INNERTUBE_CONTEXT_CLIENT_VERSION","X-YouTube-Delegation-Context":"INNERTUBE_CONTEXT_SERIALIZED_DELEGATION_CONTEXT","X-YouTube-Device":"DEVICE","X-Youtube-Identity-Token":"ID_TOKEN","X-YouTube-Page-CL":"PAGE_CL","X-YouTube-Page-Label":"PAGE_BUILD_LABEL",
"X-YouTube-Variants-Checksum":"VARIANTS_CHECKSUM"},ig="app debugcss debugjs expflag force_ad_params force_ad_encrypted force_viral_ad_response_params forced_experiments innertube_snapshots innertube_goldens internalcountrycode internalipoverride absolute_experiments conditional_experiments sbb sr_bns_address".split(" ").concat(ha("client_dev_mss_url client_dev_regex_map client_dev_root_url expflag jsfeat jsmode client_rollout_override".split(" "))),jg=!1;
function kg(a,b){b=void 0===b?{}:b;var c=Sf(a),d=O("web_ajax_ignore_global_headers_if_set"),e;for(e in hg){var f=N(hg[e]);!f||!c&&Lb(a)||d&&void 0!==b[e]||(b[e]=f)}if(c||!Lb(a))b["X-YouTube-Utc-Offset"]=String(-(new Date).getTimezoneOffset());if(c||!Lb(a)){try{var g=(new Intl.DateTimeFormat).resolvedOptions().timeZone}catch(h){}g&&(b["X-YouTube-Time-Zone"]=g)}if(c||!Lb(a))b["X-YouTube-Ad-Signals"]=Pf(dg(void 0));return b}
function lg(a){var b=window.location.search,c=Lb(a);O("debug_handle_relative_url_for_query_forward_killswitch")||c||!Sf(a)||(c=document.location.hostname);var d=Kb(a.match(Jb)[5]||null);d=(c=c&&(c.endsWith("youtube.com")||c.endsWith("youtube-nocookie.com")))&&d&&d.startsWith("/api/");if(!c||d)return a;var e=Qf(b),f={};G(ig,function(g){e[g]&&(f[g]=e[g])});
return Rf(a,f||{},!1)}
function mg(a,b){var c=b.format||"JSON";a=ng(a,b);var d=og(a,b),e=!1,f=pg(a,function(k){if(!e){e=!0;h&&window.clearTimeout(h);a:switch(k&&"status"in k?k.status:-1){case 200:case 201:case 202:case 203:case 204:case 205:case 206:case 304:var l=!0;break a;default:l=!1}var n=null,p=400<=k.status&&500>k.status,u=500<=k.status&&600>k.status;if(l||p||u)n=qg(a,c,k,b.convertToSafeHtml);if(l)a:if(k&&204==k.status)l=!0;else{switch(c){case "XML":l=0==parseInt(n&&n.return_code,10);break a;case "RAW":l=!0;break a}l=
!!n}n=n||{};p=b.context||B;l?b.onSuccess&&b.onSuccess.call(p,k,n):b.onError&&b.onError.call(p,k,n);b.onFinish&&b.onFinish.call(p,k,n)}},b.method,d,b.headers,b.responseType,b.withCredentials);
if(b.onTimeout&&0<b.timeout){var g=b.onTimeout;var h=If(function(){e||(e=!0,f.abort(),window.clearTimeout(h),g.call(b.context||B,f))},b.timeout)}}
function ng(a,b){b.includeDomain&&(a=document.location.protocol+"//"+document.location.hostname+(document.location.port?":"+document.location.port:"")+a);var c=N("XSRF_FIELD_NAME",void 0);if(b=b.urlParams)b[c]&&delete b[c],a=Rf(a,b||{},!0);return a}
function og(a,b){var c=N("XSRF_FIELD_NAME",void 0),d=N("XSRF_TOKEN",void 0),e=b.postBody||"",f=b.postParams,g=N("XSRF_FIELD_NAME",void 0),h;b.headers&&(h=b.headers["Content-Type"]);b.excludeXsrf||Lb(a)&&!b.withCredentials&&Lb(a)!=document.location.hostname||"POST"!=b.method||h&&"application/x-www-form-urlencoded"!=h||b.postParams&&b.postParams[g]||(f||(f={}),f[c]=d);f&&"string"===typeof e&&(e=Qf(e),hb(e,f),e=b.postBodyFormat&&"JSON"==b.postBodyFormat?JSON.stringify(e):Ob(e));if(!(a=e)&&(a=f)){a:{for(var k in f){f=
!1;break a}f=!0}a=!f}!jg&&a&&"POST"!=b.method&&(jg=!0,yf(Error("AJAX request with postData should use POST")));return e}
function qg(a,b,c,d){var e=null;switch(b){case "JSON":try{var f=c.responseText}catch(g){throw d=Error("Error reading responseText"),d.params=a,zf(d),g;}a=c.getResponseHeader("Content-Type")||"";f&&0<=a.indexOf("json")&&(")]}'\n"===f.substring(0,5)&&(f=f.substring(5)),e=JSON.parse(f));break;case "XML":if(a=(a=c.responseXML)?rg(a):null)e={},G(a.getElementsByTagName("*"),function(g){e[g.tagName]=sg(g)})}d&&tg(e);
return e}
function tg(a){if(D(a))for(var b in a){var c;(c="html_content"==b)||(c=b.length-5,c=0<=c&&b.indexOf("_html",c)==c);if(c){c=b;lb("HTML that is escaped and sanitized server-side and passed through yt.net.ajax");var d=Ib(a[b],null);a[c]=d}else tg(a[b])}}
function rg(a){return a?(a=("responseXML"in a?a.responseXML:a).getElementsByTagName("root"))&&0<a.length?a[0]:null:null}
function sg(a){var b="";G(a.childNodes,function(c){b+=c.nodeValue});
return b}
function pg(a,b,c,d,e,f,g){function h(){4==(k&&"readyState"in k?k.readyState:0)&&b&&xf(b)(k)}
c=void 0===c?"GET":c;d=void 0===d?"":d;var k=gg();if(!k)return null;"onloadend"in k?k.addEventListener("loadend",h,!1):k.onreadystatechange=h;O("debug_forward_web_query_parameters")&&(a=lg(a));k.open(c,a,!0);f&&(k.responseType=f);g&&(k.withCredentials=!0);c="POST"==c&&(void 0===window.FormData||!(d instanceof FormData));if(e=kg(a,e))for(var l in e)k.setRequestHeader(l,e[l]),"content-type"==l.toLowerCase()&&(c=!1);c&&k.setRequestHeader("Content-Type","application/x-www-form-urlencoded");k.send(d);
return k}
;var ug=hc||ic;function vg(a){var b=Bb;return b?0<=b.toLowerCase().indexOf(a):!1}
;var wg={},xg=0;
function yg(a,b,c,d,e){e=void 0===e?"":e;if(a)if(c&&!vg("cobalt"))a&&(a instanceof vb||(a="object"==typeof a&&a.ga?a.fa():String(a),zb.test(a)?a=new vb(a,wb):(a=String(a),a=a.replace(/(%0A|%0D)/g,""),a=(b=a.match(yb))&&xb.test(b[1])?new vb(a,wb):null)),a=a||Ab,a instanceof vb&&a.constructor===vb?a=a.h:(Ja(a),a="type_error:SafeUrl"),"about:invalid#zClosurez"===a||a.startsWith("data")?a="":(a instanceof Hb||(b="object"==typeof a,c=null,b&&a.Qa&&(c=a.Oa()),a=Ib(nb(b&&a.ga?a.fa():String(a)),c)),a instanceof
Hb&&a.constructor===Hb?a=a.h:(Ja(a),a="type_error:SafeHtml"),a=encodeURIComponent(String(Ce(a.toString())))),/^[\s\xa0]*$/.test(a)||(a=Oc("IFRAME",{src:'javascript:"<body><img src=\\""+'+a+'+"\\"></body>"',style:"display:none"}),(9==a.nodeType?a:a.ownerDocument||a.document).body.appendChild(a)));else if(e)pg(a,b,"POST",e,d);else if(N("USE_NET_AJAX_FOR_PING_TRANSPORT",!1)||d)pg(a,b,"GET","",d);else{b:{try{var f=new Ta({url:a});if(f.j&&f.i||f.l){var g=Kb(a.match(Jb)[5]||null);var h=!(!g||!g.endsWith("/aclk")||
"1"!==Qb(a,"ri"));break b}}catch(k){}h=!1}h?zg(a)?(b&&b(),c=!0):c=!1:c=!1;c||Ag(a,b)}}
function Bg(){var a=void 0===a?"":a;zg("/generate_204",a)||yg("/generate_204",void 0,void 0,void 0,a)}
function zg(a,b){try{if(window.navigator&&window.navigator.sendBeacon&&window.navigator.sendBeacon(a,void 0===b?"":b))return!0}catch(c){}return!1}
function Ag(a,b){var c=new Image,d=""+xg++;wg[d]=c;c.onload=c.onerror=function(){b&&wg[d]&&b();delete wg[d]};
c.src=a}
;var Cg=B.ytPubsubPubsubInstance||new L,Dg=B.ytPubsubPubsubSubscribedKeys||{},Eg=B.ytPubsubPubsubTopicToKeys||{},Fg=B.ytPubsubPubsubIsSynchronous||{};L.prototype.subscribe=L.prototype.subscribe;L.prototype.unsubscribeByKey=L.prototype.ka;L.prototype.publish=L.prototype.ba;L.prototype.clear=L.prototype.clear;E("ytPubsubPubsubInstance",Cg);E("ytPubsubPubsubTopicToKeys",Eg);E("ytPubsubPubsubIsSynchronous",Fg);E("ytPubsubPubsubSubscribedKeys",Dg);var Gg=window,P=Gg.ytcsi&&Gg.ytcsi.now?Gg.ytcsi.now:Gg.performance&&Gg.performance.timing&&Gg.performance.now&&Gg.performance.timing.navigationStart?function(){return Gg.performance.timing.navigationStart+Gg.performance.now()}:function(){return(new Date).getTime()};var Hg=Uf("initial_gel_batch_timeout",2E3),Ig=Math.pow(2,16)-1,Jg=void 0,Kg=0,Lg=0,Mg=0,Ng=!0,Og=B.ytLoggingTransportGELQueue_||new Map;E("ytLoggingTransportGELQueue_",Og);var Pg=B.ytLoggingTransportTokensToCttTargetIds_||{};E("ytLoggingTransportTokensToCttTargetIds_",Pg);
function Qg(a,b){if("log_event"===a.endpoint){var c=Rg(a),d=Og.get(c)||[];Og.set(c,d);d.push(a.payload);b&&(Jg=new b);a=Uf("tvhtml5_logging_max_batch")||Uf("web_logging_max_batch")||100;b=P();d.length>=a?Sg({writeThenSend:!0},O("flush_only_full_queue")?c:void 0):10<=b-Mg&&(Tg(),Mg=b)}}
function Ug(a,b){if("log_event"===a.endpoint){var c=Rg(a),d=new Map;d.set(c,[a.payload]);b&&(Jg=new b);return new De(function(e){Jg&&Jg.isReady()?Vg(d,e,{bypassNetworkless:!0},!0):e()})}}
function Rg(a){var b="";if(a.za)b="visitorOnlyApprovedKey";else if(a.ca){b=a.ca;var c={};b.videoId?c.videoId=b.videoId:b.playlistId&&(c.playlistId=b.playlistId);Pg[a.ca.token]=c;b=a.ca.token}return b}
function Sg(a,b){a=void 0===a?{}:a;new De(function(c){window.clearTimeout(Kg);window.clearTimeout(Lg);Lg=0;if(Jg&&Jg.isReady())if(void 0!==b){var d=new Map,e=Og.get(b)||[];d.set(b,e);Vg(d,c,a);Og.delete(b)}else Vg(Og,c,a),Og.clear();else Tg(),c()})}
function Tg(){O("web_gel_timeout_cap")&&!Lg&&(Lg=If(function(){Sg({writeThenSend:!0})},6E4));
window.clearTimeout(Kg);var a=N("LOGGING_BATCH_TIMEOUT",Uf("web_gel_debounce_ms",1E4));O("shorten_initial_gel_batch_timeout")&&Ng&&(a=Hg);Kg=If(function(){Sg({writeThenSend:!0})},a)}
function Vg(a,b,c,d){var e=Jg;c=void 0===c?{}:c;var f=Math.round(P()),g=a.size;a=t(a);for(var h=a.next();!h.done;h=a.next()){var k=t(h.value);h=k.next().value;var l=k=k.next().value;k=fb({context:Wg(e.config_||Xg())});k.events=l;(l=Pg[h])&&Yg(k,h,l);delete Pg[h];h="visitorOnlyApprovedKey"===h;Zg(k,f,h);O("always_send_and_write")&&(c.writeThenSend=!1);O("send_beacon_before_gel")&&window.navigator&&window.navigator.sendBeacon&&!c.writeThenSend&&Bg();$g(e,"log_event",k,ah(c,h,function(){g--;g||b()},
function(){g--;
g||b()},d));
Ng=!1}}
function ah(a,b,c,d,e){return{retry:!0,onSuccess:c,onError:d,Ta:a,za:b,Kb:!!e}}
function Zg(a,b,c){a.requestTimeMs=String(b);O("unsplit_gel_payloads_in_logs")&&(a.unsplitGelPayloadsInLogs=!0);!c&&(b=N("EVENT_ID",void 0))&&((c=N("BATCH_CLIENT_COUNTER",void 0)||0)||(c=Math.floor(Math.random()*Ig/2)),c++,c>Ig&&(c=1),tf("BATCH_CLIENT_COUNTER",c),a.serializedClientEventId={serializedEventId:b,clientCounter:String(c)})}
function Yg(a,b,c){if(c.videoId)var d="VIDEO";else if(c.playlistId)d="PLAYLIST";else return;a.credentialTransferTokenTargetId=c;a.context=a.context||{};a.context.user=a.context.user||{};a.context.user.credentialTransferTokens=[{token:b,scope:d}]}
;var bh=B.ytLoggingGelSequenceIdObj_||{};E("ytLoggingGelSequenceIdObj_",bh);function ch(){if(!B.matchMedia)return"WEB_DISPLAY_MODE_UNKNOWN";try{return B.matchMedia("(display-mode: standalone)").matches?"WEB_DISPLAY_MODE_STANDALONE":B.matchMedia("(display-mode: minimal-ui)").matches?"WEB_DISPLAY_MODE_MINIMAL_UI":B.matchMedia("(display-mode: fullscreen)").matches?"WEB_DISPLAY_MODE_FULLSCREEN":B.matchMedia("(display-mode: browser)").matches?"WEB_DISPLAY_MODE_BROWSER":"WEB_DISPLAY_MODE_UNKNOWN"}catch(a){return"WEB_DISPLAY_MODE_UNKNOWN"}}
;E("ytglobal.prefsUserPrefsPrefs_",C("ytglobal.prefsUserPrefsPrefs_")||{});var dh={bluetooth:"CONN_DISCO",cellular:"CONN_CELLULAR_UNKNOWN",ethernet:"CONN_WIFI",none:"CONN_NONE",wifi:"CONN_WIFI",wimax:"CONN_CELLULAR_4G",other:"CONN_UNKNOWN",unknown:"CONN_UNKNOWN","slow-2g":"CONN_CELLULAR_2G","2g":"CONN_CELLULAR_2G","3g":"CONN_CELLULAR_3G","4g":"CONN_CELLULAR_4G"},eh={"slow-2g":"EFFECTIVE_CONNECTION_TYPE_SLOW_2G","2g":"EFFECTIVE_CONNECTION_TYPE_2G","3g":"EFFECTIVE_CONNECTION_TYPE_3G","4g":"EFFECTIVE_CONNECTION_TYPE_4G"};
function fh(){var a=B.navigator;return a?a.connection:void 0}
;function gh(){return"INNERTUBE_API_KEY"in qf&&"INNERTUBE_API_VERSION"in qf}
function Xg(){return{innertubeApiKey:N("INNERTUBE_API_KEY",void 0),innertubeApiVersion:N("INNERTUBE_API_VERSION",void 0),lb:N("INNERTUBE_CONTEXT_CLIENT_CONFIG_INFO"),Ba:N("INNERTUBE_CONTEXT_CLIENT_NAME","WEB"),Mb:N("INNERTUBE_CONTEXT_CLIENT_NAME",1),innertubeContextClientVersion:N("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0),nb:N("INNERTUBE_CONTEXT_HL",void 0),mb:N("INNERTUBE_CONTEXT_GL",void 0),ob:N("INNERTUBE_HOST_OVERRIDE",void 0)||"",qb:!!N("INNERTUBE_USE_THIRD_PARTY_AUTH",!1),pb:!!N("INNERTUBE_OMIT_API_KEY_WHEN_AUTH_HEADER_IS_PRESENT",
!1),appInstallData:N("SERIALIZED_CLIENT_CONFIG_DATA",void 0)}}
function Wg(a){var b={client:{hl:a.nb,gl:a.mb,clientName:a.Ba,clientVersion:a.innertubeContextClientVersion,configInfo:a.lb}};navigator.userAgent&&(b.client.userAgent=String(navigator.userAgent));var c=B.devicePixelRatio;c&&1!=c&&(b.client.screenDensityFloat=String(c));c=N("EXPERIMENTS_TOKEN","");""!==c&&(b.client.experimentsToken=c);c=[];var d=N("EXPERIMENTS_FORCED_FLAGS",{});for(e in d)c.push({key:e,value:String(d[e])});var e=N("EXPERIMENT_FLAGS",{});for(var f in e)f.startsWith("force_")&&void 0===
d[f]&&c.push({key:f,value:String(e[f])});0<c.length&&(b.request={internalExperimentFlags:c});f=a.Ba;if(("WEB"===f||"MWEB"===f||1===f||2===f)&&b){var g;b.client.mainAppWebInfo=null!=(g=b.client.mainAppWebInfo)?g:{};b.client.mainAppWebInfo.webDisplayMode=ch()}g=a.Ba;if(("WEB_REMIX"===g||76===g)&&!O("music_web_display_mode_killswitch")&&b){var h;b.client.Sa=null!=(h=b.client.Sa)?h:{};b.client.Sa.webDisplayMode=ch()}var k;if(O("web_log_memory_total_kbytes")&&(null==(k=B.navigator)?0:k.deviceMemory)){var l;
h=null==(l=B.navigator)?void 0:l.deviceMemory;b&&(b.client.memoryTotalKbytes=""+1E6*h)}a.appInstallData&&b&&(b.client.configInfo=b.client.configInfo||{},b.client.configInfo.appInstallData=a.appInstallData);a:{if(l=fh()){a=dh[l.type||"unknown"]||"CONN_UNKNOWN";l=dh[l.effectiveType||"unknown"]||"CONN_UNKNOWN";"CONN_CELLULAR_UNKNOWN"===a&&"CONN_UNKNOWN"!==l&&(a=l);if("CONN_UNKNOWN"!==a)break a;if("CONN_UNKNOWN"!==l){a=l;break a}}a=void 0}a&&b&&(b.client.connectionType=a);O("web_log_effective_connection_type")&&
(a=fh(),a=null!==a&&void 0!==a&&a.effectiveType?eh.hasOwnProperty(a.effectiveType)?eh[a.effectiveType]:"EFFECTIVE_CONNECTION_TYPE_UNKNOWN":void 0,a&&b&&(b.client.effectiveConnectionType=a));N("DELEGATED_SESSION_ID")&&!O("pageid_as_header_web")&&(b.user={onBehalfOfUser:N("DELEGATED_SESSION_ID")});a=Object;l=a.assign;h=b.client;k={};g=t(Object.entries(Qf(N("DEVICE",""))));for(f=g.next();!f.done;f=g.next())e=t(f.value),f=e.next().value,e=e.next().value,"cbrand"===f?k.deviceMake=e:"cmodel"===f?k.deviceModel=
e:"cbr"===f?k.browserName=e:"cbrver"===f?k.browserVersion=e:"cos"===f?k.osName=e:"cosver"===f?k.osVersion=e:"cplatform"===f&&(k.platform=e);b.client=l.call(a,h,k);return b}
function hh(a,b,c){c=void 0===c?{}:c;var d={"X-Goog-Visitor-Id":c.visitorData||N("VISITOR_DATA","")};if(b&&b.includes("www.youtube-nocookie.com"))return d;(b=c.Ib||N("AUTHORIZATION"))||(a?b="Bearer "+C("gapi.auth.getToken")().Hb:b=id([]));b&&(d.Authorization=b,d["X-Goog-AuthUser"]=N("SESSION_INDEX",0),O("pageid_as_header_web")&&(d["X-Goog-PageId"]=N("DELEGATED_SESSION_ID")));return d}
;function ih(a){a=Object.assign({},a);delete a.Authorization;var b=id();if(b){var c=new le;c.update(N("INNERTUBE_API_KEY",void 0));c.update(b);a.hash=mc(c.digest(),3)}return a}
;function jh(a){var b=new df;(b=b.isAvailable()?a?new kf(b,a):b:null)||(a=new ef(a||"UserDataSharedStore"),b=a.isAvailable()?a:null);this.h=(a=b)?new $e(a):null;this.i=document.domain||window.location.hostname}
jh.prototype.set=function(a,b,c,d){c=c||31104E3;this.remove(a);if(this.h)try{this.h.set(a,b,Date.now()+1E3*c);return}catch(f){}var e="";if(d)try{e=escape(Ce(b))}catch(f){return}else e=escape(b);b=this.i;fd.set(""+a,e,{Ca:c,path:"/",domain:void 0===b?"youtube.com":b,secure:!1})};
jh.prototype.get=function(a,b){var c=void 0,d=!this.h;if(!d)try{c=this.h.get(a)}catch(e){d=!0}if(d&&(c=fd.get(""+a,void 0))&&(c=unescape(c),b))try{c=JSON.parse(c)}catch(e){this.remove(a),c=void 0}return c};
jh.prototype.remove=function(a){this.h&&this.h.remove(a);var b=this.i;fd.remove(""+a,"/",void 0===b?"youtube.com":b)};var kh;function lh(){kh||(kh=new jh("yt.innertube"));return kh}
function mh(a,b,c,d){if(d)return null;d=lh().get("nextId",!0)||1;var e=lh().get("requests",!0)||{};e[d]={method:a,request:b,authState:ih(c),requestTime:Math.round(P())};lh().set("nextId",d+1,86400,!0);lh().set("requests",e,86400,!0);return d}
function nh(a){var b=lh().get("requests",!0)||{};delete b[a];lh().set("requests",b,86400,!0)}
function oh(a){var b=lh().get("requests",!0);if(b){for(var c in b){var d=b[c];if(!(6E4>Math.round(P())-d.requestTime)){var e=d.authState,f=ih(hh(!1));eb(e,f)&&(e=d.request,"requestTimeMs"in e&&(e.requestTimeMs=Math.round(P())),$g(a,d.method,e,{}));delete b[c]}}lh().set("requests",b,86400,!0)}}
;var ph=function(){var a;return function(){a||(a=new jh("ytidb"));return a}}();
function qh(){var a;return null===(a=ph())||void 0===a?void 0:a.get("LAST_RESULT_ENTRY_KEY",!0)}
;var rh=[],sh=!1;function th(a){sh||(rh.push({type:"ERROR",payload:a}),10<rh.length&&rh.shift())}
function uh(a,b){sh||(rh.push({type:"EVENT",eventType:a,payload:b}),10<rh.length&&rh.shift())}
;function vh(a){var b=Da.apply(1,arguments);var c=Error.call(this,a);this.message=c.message;"stack"in c&&(this.stack=c.stack);this.args=[].concat(ha(b))}
w(vh,Error);function wh(){try{return xh(),!0}catch(a){return!1}}
function xh(){if(void 0!==N("DATASYNC_ID",void 0))return N("DATASYNC_ID",void 0);throw new vh("Datasync ID not set","unknown");}
;function yh(a){if(0<=a.indexOf(":"))throw Error("Database name cannot contain ':'");}
function zh(a){return a.substr(0,a.indexOf(":"))||a}
;var Q={},Ah=(Q.AUTH_INVALID="No user identifier specified.",Q.EXPLICIT_ABORT="Transaction was explicitly aborted.",Q.IDB_NOT_SUPPORTED="IndexedDB is not supported.",Q.MISSING_INDEX="Index not created.",Q.MISSING_OBJECT_STORES="Object stores not created.",Q.DB_DELETED_BY_MISSING_OBJECT_STORES="Database is deleted because expected object stores were not created.",Q.UNKNOWN_ABORT="Transaction was aborted for unknown reasons.",Q.QUOTA_EXCEEDED="The current transaction exceeded its quota limitations.",
Q.QUOTA_MAYBE_EXCEEDED="The current transaction may have failed because of exceeding quota limitations.",Q.EXECUTE_TRANSACTION_ON_CLOSED_DB="Can't start a transaction on a closed database",Q.INCOMPATIBLE_DB_VERSION="The binary is incompatible with the database version",Q),R={},Bh=(R.AUTH_INVALID="ERROR",R.EXECUTE_TRANSACTION_ON_CLOSED_DB="WARNING",R.EXPLICIT_ABORT="IGNORED",R.IDB_NOT_SUPPORTED="ERROR",R.MISSING_INDEX="WARNING",R.MISSING_OBJECT_STORES="ERROR",R.DB_DELETED_BY_MISSING_OBJECT_STORES=
"WARNING",R.QUOTA_EXCEEDED="WARNING",R.QUOTA_MAYBE_EXCEEDED="WARNING",R.UNKNOWN_ABORT="WARNING",R.INCOMPATIBLE_DB_VERSION="WARNING",R),S={},Ch=(S.AUTH_INVALID=!1,S.EXECUTE_TRANSACTION_ON_CLOSED_DB=!1,S.EXPLICIT_ABORT=!1,S.IDB_NOT_SUPPORTED=!1,S.MISSING_INDEX=!1,S.MISSING_OBJECT_STORES=!1,S.DB_DELETED_BY_MISSING_OBJECT_STORES=!1,S.QUOTA_EXCEEDED=!1,S.QUOTA_MAYBE_EXCEEDED=!0,S.UNKNOWN_ABORT=!0,S.INCOMPATIBLE_DB_VERSION=!1,S);
function T(a,b,c,d,e){b=void 0===b?{}:b;c=void 0===c?Ah[a]:c;d=void 0===d?Bh[a]:d;e=void 0===e?Ch[a]:e;vh.call(this,c,Object.assign({name:"YtIdbKnownError",isSw:void 0===self.document,isIframe:self!==self.top,type:a},b));this.type=a;this.message=c;this.level=d;this.h=e;Object.setPrototypeOf(this,T.prototype)}
w(T,vh);function Dh(a,b){T.call(this,"MISSING_OBJECT_STORES",{expectedObjectStores:b,foundObjectStores:a},Ah.MISSING_OBJECT_STORES);Object.setPrototypeOf(this,Dh.prototype)}
w(Dh,T);function Eh(a,b){var c=Error.call(this);this.message=c.message;"stack"in c&&(this.stack=c.stack);this.index=a;this.objectStore=b;Object.setPrototypeOf(this,Eh.prototype)}
w(Eh,Error);var Fh=["The database connection is closing","Can't start a transaction on a closed database","A mutation operation was attempted on a database that did not allow mutations"];
function Gh(a,b,c,d){b=zh(b);var e=a instanceof Error?a:Error("Unexpected error: "+a);if(e instanceof T)return e;a={objectStoreNames:c,dbName:b,dbVersion:d};if("QuotaExceededError"===e.name)return new T("QUOTA_EXCEEDED",a);if(jc&&"UnknownError"===e.name)return new T("QUOTA_MAYBE_EXCEEDED",a);if(e instanceof Eh)return new T("MISSING_INDEX",Object.assign(Object.assign({},a),{objectStore:e.objectStore,index:e.index}));if("InvalidStateError"===e.name&&Fh.some(function(f){return e.message.includes(f)}))return new T("EXECUTE_TRANSACTION_ON_CLOSED_DB",
a);
if("AbortError"===e.name)return new T("UNKNOWN_ABORT",a,e.message);e.args=[Object.assign(Object.assign({},a),{name:"IdbError",Qb:e.name})];e.level="WARNING";return e}
function Hh(a,b,c){var d=qh();return new T("IDB_NOT_SUPPORTED",{context:{caller:a,publicName:b,version:c,hasSucceededOnce:null===d||void 0===d?void 0:d.hasSucceededOnce}})}
;function Ih(a){if(!a)throw Error();throw a;}
function Jh(a){return a}
function Kh(a){this.h=a}
function U(a){function b(e){if("PENDING"===d.state.status){d.state={status:"REJECTED",reason:e};e=t(d.onRejected);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
function c(e){if("PENDING"===d.state.status){d.state={status:"FULFILLED",value:e};e=t(d.h);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
var d=this;this.state={status:"PENDING"};this.h=[];this.onRejected=[];a=a.h;try{a(c,b)}catch(e){b(e)}}
U.all=function(a){return new U(new Kh(function(b,c){var d=[],e=a.length;0===e&&b(d);for(var f={Y:0};f.Y<a.length;f={Y:f.Y},++f.Y)Lh(U.resolve(a[f.Y]).then(function(g){return function(h){d[g.Y]=h;e--;0===e&&b(d)}}(f)),function(g){c(g)})}))};
U.resolve=function(a){return new U(new Kh(function(b,c){a instanceof U?a.then(b,c):b(a)}))};
U.reject=function(a){return new U(new Kh(function(b,c){c(a)}))};
U.prototype.then=function(a,b){var c=this,d=null!==a&&void 0!==a?a:Jh,e=null!==b&&void 0!==b?b:Ih;return new U(new Kh(function(f,g){"PENDING"===c.state.status?(c.h.push(function(){Mh(c,c,d,f,g)}),c.onRejected.push(function(){Nh(c,c,e,f,g)})):"FULFILLED"===c.state.status?Mh(c,c,d,f,g):"REJECTED"===c.state.status&&Nh(c,c,e,f,g)}))};
function Lh(a,b){a.then(void 0,b)}
function Mh(a,b,c,d,e){try{if("FULFILLED"!==a.state.status)throw Error("calling handleResolve before the promise is fulfilled.");var f=c(a.state.value);f instanceof U?Oh(a,b,f,d,e):d(f)}catch(g){e(g)}}
function Nh(a,b,c,d,e){try{if("REJECTED"!==a.state.status)throw Error("calling handleReject before the promise is rejected.");var f=c(a.state.reason);f instanceof U?Oh(a,b,f,d,e):d(f)}catch(g){e(g)}}
function Oh(a,b,c,d,e){b===c?e(new TypeError("Circular promise chain detected.")):c.then(function(f){f instanceof U?Oh(a,b,f,d,e):d(f)},function(f){e(f)})}
;function Ph(a,b,c){function d(){c(a.error);f()}
function e(){b(a.result);f()}
function f(){try{a.removeEventListener("success",e),a.removeEventListener("error",d)}catch(g){}}
a.addEventListener("success",e);a.addEventListener("error",d)}
function Qh(a){return new Promise(function(b,c){Ph(a,b,c)})}
function V(a){return new U(new Kh(function(b,c){Ph(a,b,c)}))}
;function Rh(a,b){return new U(new Kh(function(c,d){function e(){var f=a?b(a):null;f?f.then(function(g){a=g;e()},d):c()}
e()}))}
;function Sh(a,b){this.h=a;this.options=b;this.transactionCount=0;this.j=Math.round(P());this.i=!1}
m=Sh.prototype;m.add=function(a,b,c){return W(this,[a],{mode:"readwrite",G:!0},function(d){return d.objectStore(a).add(b,c)})};
m.clear=function(a){return W(this,[a],{mode:"readwrite",G:!0},function(b){return b.objectStore(a).clear()})};
m.close=function(){var a;this.h.close();(null===(a=this.options)||void 0===a?0:a.closed)&&this.options.closed()};
m.count=function(a,b){return W(this,[a],{mode:"readonly",G:!0},function(c){return c.objectStore(a).count(b)})};
function Th(a,b,c){a=a.h.createObjectStore(b,c);return new Uh(a)}
m.delete=function(a,b){return W(this,[a],{mode:"readwrite",G:!0},function(c){return c.objectStore(a).delete(b)})};
m.get=function(a,b){return W(this,[a],{mode:"readonly",G:!0},function(c){return c.objectStore(a).get(b)})};
function Vh(a,b){return W(a,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(c){c=c.objectStore("LogsRequestsStore");return V(c.h.put(b,void 0))})}
m.objectStoreNames=function(){return Array.from(this.h.objectStoreNames)};
function W(a,b,c,d){var e,f,g,h,k,l,n,p,u,q,v,x;return z(function(A){switch(A.h){case 1:var J={mode:"readonly",G:!1,tag:"IDB_TRANSACTION_TAG_UNKNOWN"};"string"===typeof c?J.mode=c:Object.assign(J,c);e=J;a.transactionCount++;f=e.G?3:1;g=0;case 2:if(h){A.o(3);break}g++;k=Math.round(P());sa(A,4);l=a.h.transaction(b,e.mode);J=new Wh(l);J=Xh(J,d);return y(A,J,6);case 6:return n=A.i,p=Math.round(P()),Yh(a,k,p,g,void 0,b.join(),e),A.return(n);case 4:u=ua(A);q=Math.round(P());v=Gh(u,a.h.name,b.join(),a.h.version);
if((x=v instanceof T&&!v.h)||g>=f)Yh(a,k,q,g,v,b.join(),e),h=v;A.o(2);break;case 3:return A.return(Promise.reject(h))}})}
function Yh(a,b,c,d,e,f,g){b=c-b;e?(e instanceof T&&("QUOTA_EXCEEDED"===e.type||"QUOTA_MAYBE_EXCEEDED"===e.type)&&uh("QUOTA_EXCEEDED",{dbName:zh(a.h.name),objectStoreNames:f,transactionCount:a.transactionCount,transactionMode:g.mode}),e instanceof T&&"UNKNOWN_ABORT"===e.type&&(c-=a.j,0>c&&c>=Math.pow(2,31)&&(c=0),uh("TRANSACTION_UNEXPECTEDLY_ABORTED",{objectStoreNames:f,transactionDuration:b,transactionCount:a.transactionCount,dbDuration:c}),a.i=!0),Zh(a,!1,d,f,b,g.tag),th(e)):Zh(a,!0,d,f,b,g.tag)}
function Zh(a,b,c,d,e,f){uh("TRANSACTION_ENDED",{objectStoreNames:d,connectionHasUnknownAbortedTransaction:a.i,duration:e,isSuccessful:b,tryCount:c,tag:void 0===f?"IDB_TRANSACTION_TAG_UNKNOWN":f})}
m.getName=function(){return this.h.name};
function Uh(a){this.h=a}
m=Uh.prototype;m.add=function(a,b){return V(this.h.add(a,b))};
m.autoIncrement=function(){return this.h.autoIncrement};
m.clear=function(){return V(this.h.clear()).then(function(){})};
m.count=function(a){return V(this.h.count(a))};
function $h(a,b){return ai(a,{query:b},function(c){return c.delete().then(function(){return c.continue()})}).then(function(){})}
m.delete=function(a){return a instanceof IDBKeyRange?$h(this,a):V(this.h.delete(a))};
m.get=function(a){return V(this.h.get(a))};
m.index=function(a){try{return new bi(this.h.index(a))}catch(b){if(b instanceof Error&&"NotFoundError"===b.name)throw new Eh(a,this.h.name);throw b;}};
m.getName=function(){return this.h.name};
m.keyPath=function(){return this.h.keyPath};
function ai(a,b,c){a=a.h.openCursor(b.query,b.direction);return ci(a).then(function(d){return Rh(d,c)})}
function Wh(a){var b=this;this.h=a;this.j=new Map;this.i=!1;this.done=new Promise(function(c,d){b.h.addEventListener("complete",function(){c()});
b.h.addEventListener("error",function(e){e.currentTarget===e.target&&d(b.h.error)});
b.h.addEventListener("abort",function(){var e=b.h.error;if(e)d(e);else if(!b.i){e=T;for(var f=b.h.objectStoreNames,g=[],h=0;h<f.length;h++){var k=f.item(h);if(null===k)throw Error("Invariant: item in DOMStringList is null");g.push(k)}e=new e("UNKNOWN_ABORT",{objectStoreNames:g.join(),dbName:b.h.db.name,mode:b.h.mode});d(e)}})})}
function Xh(a,b){var c=new Promise(function(d,e){try{Lh(b(a).then(function(f){d(f)}),e)}catch(f){e(f),a.abort()}});
return Promise.all([c,a.done]).then(function(d){return t(d).next().value})}
Wh.prototype.abort=function(){this.h.abort();this.i=!0;throw new T("EXPLICIT_ABORT");};
Wh.prototype.objectStore=function(a){a=this.h.objectStore(a);var b=this.j.get(a);b||(b=new Uh(a),this.j.set(a,b));return b};
function bi(a){this.h=a}
m=bi.prototype;m.count=function(a){return V(this.h.count(a))};
m.delete=function(a){return di(this,{query:a},function(b){return b.delete().then(function(){return b.continue()})})};
m.get=function(a){return V(this.h.get(a))};
m.getKey=function(a){return V(this.h.getKey(a))};
m.keyPath=function(){return this.h.keyPath};
m.unique=function(){return this.h.unique};
function di(a,b,c){a=a.h.openCursor(void 0===b.query?null:b.query,void 0===b.direction?"next":b.direction);return ci(a).then(function(d){return Rh(d,c)})}
function ei(a,b){this.request=a;this.cursor=b}
function ci(a){return V(a).then(function(b){return b?new ei(a,b):null})}
m=ei.prototype;m.advance=function(a){this.cursor.advance(a);return ci(this.request)};
m.continue=function(a){this.cursor.continue(a);return ci(this.request)};
m.delete=function(){return V(this.cursor.delete()).then(function(){})};
m.getKey=function(){return this.cursor.key};
m.update=function(a){return V(this.cursor.update(a))};function fi(a,b,c){return new Promise(function(d,e){function f(){u||(u=new Sh(g.result,{closed:p}));return u}
var g=void 0!==b?self.indexedDB.open(a,b):self.indexedDB.open(a);var h=c.blocked,k=c.blocking,l=c.ub,n=c.upgrade,p=c.closed,u;g.addEventListener("upgradeneeded",function(q){try{if(null===q.newVersion)throw Error("Invariant: newVersion on IDbVersionChangeEvent is null");if(null===g.transaction)throw Error("Invariant: transaction on IDbOpenDbRequest is null");q.dataLoss&&"none"!==q.dataLoss&&uh("IDB_DATA_CORRUPTED",{reason:q.dataLossMessage||"unknown reason",dbName:zh(a)});var v=f(),x=new Wh(g.transaction);
n&&n(v,function(A){return q.oldVersion<A&&q.newVersion>=A},x);
x.done.catch(function(A){e(A)})}catch(A){e(A)}});
g.addEventListener("success",function(){var q=g.result;k&&q.addEventListener("versionchange",function(){k(f())});
q.addEventListener("close",function(){uh("IDB_UNEXPECTEDLY_CLOSED",{dbName:zh(a),dbVersion:q.version});l&&l()});
d(f())});
g.addEventListener("error",function(){e(g.error)});
h&&g.addEventListener("blocked",function(){h()})})}
function gi(a,b,c){c=void 0===c?{}:c;return fi(a,b,c)}
function hi(a,b){b=void 0===b?{}:b;var c,d,e,f;return z(function(g){if(1==g.h)return sa(g,2),c=self.indexedDB.deleteDatabase(a),d=b,(e=d.blocked)&&c.addEventListener("blocked",function(){e()}),y(g,Qh(c),4);
if(2!=g.h)return ta(g,0);f=ua(g);throw Gh(f,a,"",-1);})}
;function ii(a){return new Promise(function(b){$f(function(){b()},a)})}
function ji(a,b){this.name=a;this.options=b;this.l=!0;this.m=0;this.i=500}
ji.prototype.j=function(a,b,c){c=void 0===c?{}:c;return gi(a,b,c)};
ji.prototype.delete=function(a){a=void 0===a?{}:a;return hi(this.name,a)};
function ki(a,b){return new T("INCOMPATIBLE_DB_VERSION",{dbName:a.name,oldVersion:a.options.version,newVersion:b})}
function li(a,b){if(!b)throw Hh("openWithToken",zh(a.name));return a.open()}
ji.prototype.open=function(){function a(){var f,g,h,k,l,n,p,u,q,v;return z(function(x){switch(x.h){case 1:return h=null!==(f=Error().stack)&&void 0!==f?f:"",sa(x,2),y(x,c.j(c.name,c.options.version,e),4);case 4:k=x.i;for(var A=c.options,J=[],K=t(Object.keys(A.ha)),M=K.next();!M.done;M=K.next()){M=M.value;var Cb=A.ha[M],Id=void 0===Cb.tb?Number.MAX_VALUE:Cb.tb;!(k.h.version>=Cb.ya)||k.h.version>=Id||k.h.objectStoreNames.contains(M)||J.push(M)}l=J;if(0===l.length){x.o(5);break}n=Object.keys(c.options.ha);
p=k.objectStoreNames();if(!(c.m<Uf("ytidb_remake_db_retries",1))){x.o(6);break}c.m++;if(!O("ytidb_remake_db_enable_backoff_delay")){x.o(7);break}return y(x,ii(c.i),8);case 8:c.i*=2;case 7:return y(x,c.delete(),9);case 9:return th(new T("DB_DELETED_BY_MISSING_OBJECT_STORES",{dbName:c.name,expectedObjectStores:n,foundObjectStores:p})),x.return(a());case 6:throw new Dh(p,n);case 5:return x.return(k);case 2:u=ua(x);if(u instanceof DOMException?"VersionError"!==u.name:"DOMError"in self&&u instanceof DOMError?
"VersionError"!==u.name:!(u instanceof Object&&"message"in u)||"An attempt was made to open a database using a lower version than the existing version."!==u.message){x.o(10);break}return y(x,c.j(c.name,void 0,Object.assign(Object.assign({},e),{upgrade:void 0})),11);case 11:q=x.i;v=q.h.version;if(void 0!==c.options.version&&v>c.options.version+1)throw q.close(),c.l=!1,ki(c,v);return x.return(q);case 10:throw b(),u instanceof Error&&!O("ytidb_async_stack_killswitch")&&(u.stack=u.stack+"\n"+h.substring(h.indexOf("\n")+
1)),Gh(u,c.name,"",null!==(g=c.options.version)&&void 0!==g?g:-1);}})}
function b(){c.h===d&&(c.h=void 0)}
var c=this;if(!this.l)throw ki(this);if(this.h)return this.h;var d,e={blocking:function(f){f.close()},
closed:b,ub:b,upgrade:this.options.upgrade};return this.h=d=a()};var mi=new ji("YtIdbMeta",{ha:{databases:{ya:1}},upgrade:function(a,b){b(1)&&Th(a,"databases",{keyPath:"actualName"})}});
function ni(a,b){var c;return z(function(d){if(1==d.h)return y(d,li(mi,b),2);c=d.i;return d.return(W(c,["databases"],{G:!0,mode:"readwrite"},function(e){var f=e.objectStore("databases");return f.get(a.actualName).then(function(g){if(g?a.actualName!==g.actualName||a.publicName!==g.publicName||a.userIdentifier!==g.userIdentifier:1)return V(f.h.put(a,void 0)).then(function(){})})}))})}
function oi(a,b){var c;return z(function(d){if(1==d.h)return a?y(d,li(mi,b),2):d.return();c=d.i;return d.return(c.delete("databases",a))})}
function pi(a,b){var c,d;return z(function(e){return 1==e.h?(c=[],y(e,li(mi,b),2)):3!=e.h?(d=e.i,y(e,W(d,["databases"],{G:!0,mode:"readonly"},function(f){c.length=0;return ai(f.objectStore("databases"),{},function(g){a(g.cursor.value)&&c.push(g.cursor.value);return g.continue()})}),3)):e.return(c)})}
function qi(a){return pi(function(b){return"LogsDatabaseV2"===b.publicName&&void 0!==b.userIdentifier},a)}
;var ri,si=new function(){}(new function(){});
function ti(){var a,b,c;return z(function(d){switch(d.h){case 1:a=qh();if(null===a||void 0===a?0:a.hasSucceededOnce)return d.return(!0);var e;if(e=ug)e=/WebKit\/([0-9]+)/.exec(Bb),e=!!(e&&600<=parseInt(e[1],10));e&&(e=/WebKit\/([0-9]+)/.exec(Bb),e=!(e&&602<=parseInt(e[1],10)));if(e||Wb)return d.return(!1);try{if(b=self,!(b.indexedDB&&b.IDBIndex&&b.IDBKeyRange&&b.IDBObjectStore))return d.return(!1)}catch(f){return d.return(!1)}if(!("IDBTransaction"in self&&"objectStoreNames"in IDBTransaction.prototype))return d.return(!1);
sa(d,2);c={actualName:"yt-idb-test-do-not-use",publicName:"yt-idb-test-do-not-use",userIdentifier:void 0};return y(d,ni(c,si),4);case 4:return y(d,oi("yt-idb-test-do-not-use",si),5);case 5:return d.return(!0);case 2:return ua(d),d.return(!1)}})}
function ui(){if(void 0!==ri)return ri;sh=!0;return ri=ti().then(function(a){sh=!1;var b,c;null!==(b=ph())&&void 0!==b&&b.h&&(b=qh(),b={hasSucceededOnce:(null===b||void 0===b?void 0:b.hasSucceededOnce)||a},null===(c=ph())||void 0===c?void 0:c.set("LAST_RESULT_ENTRY_KEY",b,2592E3,!0));return a})}
function vi(){return C("ytglobal.idbToken_")||void 0}
function wi(){var a=vi();return a?Promise.resolve(a):ui().then(function(b){(b=b?si:void 0)&&E("ytglobal.idbToken_",b);return b})}
;new function(){var a=this;this.promise=new Promise(function(b,c){a.resolve=b;a.reject=c})};function xi(a){if(!wh())throw a=new T("AUTH_INVALID",{dbName:a}),th(a),a;var b=xh();return{actualName:a+":"+b,publicName:a,userIdentifier:b}}
function yi(a,b,c,d){var e,f,g,h,k,l;return z(function(n){switch(n.h){case 1:return f=null!==(e=Error().stack)&&void 0!==e?e:"",y(n,wi(),2);case 2:g=n.i;if(!g)throw h=Hh("openDbImpl",a,b),O("ytidb_async_stack_killswitch")||(h.stack=h.stack+"\n"+f.substring(f.indexOf("\n")+1)),th(h),h;yh(a);k=c?{actualName:a,publicName:a,userIdentifier:void 0}:xi(a);sa(n,3);return y(n,ni(k,g),5);case 5:return y(n,gi(k.actualName,b,d),6);case 6:return n.return(n.i);case 3:return l=ua(n),sa(n,7),y(n,oi(k.actualName,
g),9);case 9:ta(n,8);break;case 7:ua(n);case 8:throw l;}})}
function zi(a,b,c){c=void 0===c?{}:c;return yi(a,b,!1,c)}
function Ai(a,b,c){c=void 0===c?{}:c;return yi(a,b,!0,c)}
function Bi(a,b){b=void 0===b?{}:b;var c,d;return z(function(e){if(1==e.h)return y(e,wi(),2);if(3!=e.h){c=e.i;if(!c)return e.return();yh(a);d=xi(a);return y(e,hi(d.actualName,b),3)}return y(e,oi(d.actualName,c),0)})}
function Ci(a,b,c){a=a.map(function(d){return z(function(e){return 1==e.h?y(e,hi(d.actualName,b),2):y(e,oi(d.actualName,c),0)})});
return Promise.all(a).then(function(){})}
function Di(){var a=void 0===a?{}:a;var b,c;return z(function(d){if(1==d.h)return y(d,wi(),2);if(3!=d.h){b=d.i;if(!b)return d.return();yh("LogsDatabaseV2");return y(d,qi(b),3)}c=d.i;return y(d,Ci(c,a,b),0)})}
function Ei(a,b){b=void 0===b?{}:b;var c;return z(function(d){if(1==d.h)return y(d,wi(),2);if(3!=d.h){c=d.i;if(!c)return d.return();yh(a);return y(d,hi(a,b),3)}return y(d,oi(a,c),0)})}
;function Fi(a){var b,c,d,e,f,g,h,k;this.h=!1;this.potentialEsfErrorCounter=this.i=0;this.handleError=function(){};
this.aa=function(){};
this.now=Date.now;this.da=!1;this.ab=null!==(b=a.ab)&&void 0!==b?b:100;this.Ya=null!==(c=a.Ya)&&void 0!==c?c:1;this.Wa=null!==(d=a.Wa)&&void 0!==d?d:2592E6;this.Va=null!==(e=a.Va)&&void 0!==e?e:12E4;this.Xa=null!==(f=a.Xa)&&void 0!==f?f:5E3;this.s=null!==(g=a.s)&&void 0!==g?g:void 0;this.pa=!!a.pa;this.oa=null!==(h=a.oa)&&void 0!==h?h:.1;this.ta=null!==(k=a.ta)&&void 0!==k?k:10;a.handleError&&(this.handleError=a.handleError);a.aa&&(this.aa=a.aa);a.da&&(this.da=a.da);this.B=a.B;this.J=a.J;this.C=a.C;
this.F=a.F;this.P=a.P;this.Fa=a.Fa;this.Ea=a.Ea;this.s&&(!this.B||this.B("networkless_logging"))&&Gi(this)}
function Gi(a){z(function(b){if(1==b.h)return!a.s||a.da?b.return():a.pa&&Math.random()<=a.oa?y(b,a.C.ib(a.s),2):b.o(2);Hi(a);a.F.D()&&a.ja();a.F.X(a.Fa,a.ja.bind(a));a.F.X(a.Ea,a.Ja.bind(a));a.h=!0;b.h=0})}
m=Fi.prototype;m.writeThenSend=function(a,b){var c=this;b=void 0===b?{}:b;if(this.s&&this.h){var d={url:a,options:b,timestamp:this.now(),status:"NEW",sendCount:0};this.C.set(d,this.s).then(function(e){d.id=e;c.F.D()&&Ii(c,d)}).catch(function(e){Ii(c,d);
Ji(c,e)})}else this.P(a,b)};
m.sendThenWrite=function(a,b,c){var d=this;b=void 0===b?{}:b;if(this.s&&this.h){var e={url:a,options:b,timestamp:this.now(),status:"NEW",sendCount:0};this.B&&this.B("nwl_skip_retry")&&(e.skipRetry=c);if(this.F.D()||this.B&&this.B("nwl_aggressive_send_then_write")&&!e.skipRetry){if(!e.skipRetry){var f=b.onError?b.onError:function(){};
b.onError=function(g,h){return z(function(k){if(1==k.h)return y(k,d.C.set(e,d.s).catch(function(l){Ji(d,l)}),2);
f(g,h);k.h=0})}}this.P(a,b,e.skipRetry)}else this.C.set(e,this.s).catch(function(g){d.P(a,b,e.skipRetry);
Ji(d,g)})}else this.P(a,b,this.B&&this.B("nwl_skip_retry")&&c)};
m.sendAndWrite=function(a,b){var c=this;b=void 0===b?{}:b;if(this.s&&this.h){var d={url:a,options:b,timestamp:this.now(),status:"NEW",sendCount:0},e=!1,f=b.onSuccess?b.onSuccess:function(){};
d.options.onSuccess=function(g,h){void 0!==d.id?c.C.Z(d.id,c.s):e=!0;c.F.V&&c.B&&c.B("vss_network_hint")&&c.F.V(!0);f(g,h)};
this.P(d.url,d.options);this.C.set(d,this.s).then(function(g){d.id=g;e&&c.C.Z(d.id,c.s)}).catch(function(g){Ji(c,g)})}else this.P(a,b)};
m.ja=function(){var a=this;if(!this.s)throw Hh("throttleSend");this.i||(this.i=this.J.K(function(){var b;return z(function(c){if(1==c.h)return y(c,a.C.Pa("NEW",a.s),2);if(3!=c.h)return b=c.i,b?y(c,Ii(a,b),3):(a.Ja(),c.return());a.i&&(a.i=0,a.ja());c.h=0})},this.ab))};
m.Ja=function(){this.J.W(this.i);this.i=0};
function Ii(a,b){var c,d;return z(function(e){switch(e.h){case 1:if(!a.s)throw c=Hh("immediateSend"),c;if(void 0===b.id){e.o(2);break}return y(e,a.C.rb(b.id,a.s),3);case 3:(d=e.i)?b=d:a.aa(Error("The request cannot be found in the database."));case 2:if(Ki(a,b,a.Wa)){e.o(4);break}a.aa(Error("Networkless Logging: Stored logs request expired age limit"));if(void 0===b.id){e.o(5);break}return y(e,a.C.Z(b.id,a.s),5);case 5:return e.return();case 4:b.skipRetry||(b=Li(a,b));if(!b){e.o(0);break}if(!b.skipRetry||
void 0===b.id){e.o(8);break}return y(e,a.C.Z(b.id,a.s),8);case 8:a.P(b.url,b.options,!!b.skipRetry),e.h=0}})}
function Li(a,b){if(!a.s)throw Hh("updateRequestHandlers");var c=b.options.onError?b.options.onError:function(){};
b.options.onError=function(e,f){var g;return z(function(h){switch(h.h){case 1:g=Mi(f);if(!(a.B&&a.B("nwl_consider_error_code")&&g||a.B&&!a.B("nwl_consider_error_code")&&a.potentialEsfErrorCounter<=a.ta)){h.o(2);break}if(!a.F.R){h.o(3);break}return y(h,a.F.R(),3);case 3:if(a.F.D()){h.o(2);break}c(e,f);if(!a.B||!a.B("nwl_consider_error_code")||void 0===(null===b||void 0===b?void 0:b.id)){h.o(6);break}return y(h,a.C.Ga(b.id,a.s,!1),6);case 6:return h.return();case 2:if(a.B&&a.B("nwl_consider_error_code")&&
!g&&a.potentialEsfErrorCounter>a.ta)return h.return();a.potentialEsfErrorCounter++;if(void 0===(null===b||void 0===b?void 0:b.id)){h.o(8);break}return b.sendCount<a.Ya?y(h,a.C.Ga(b.id,a.s),12):y(h,a.C.Z(b.id,a.s),8);case 12:a.J.K(function(){a.F.D()&&a.ja()},a.Xa);
case 8:c(e,f),h.h=0}})};
var d=b.options.onSuccess?b.options.onSuccess:function(){};
b.options.onSuccess=function(e,f){return z(function(g){if(1==g.h)return void 0===(null===b||void 0===b?void 0:b.id)?g.o(2):y(g,a.C.Z(b.id,a.s),2);a.F.V&&a.B&&a.B("vss_network_hint")&&a.F.V(!0);d(e,f);g.h=0})};
return b}
function Ki(a,b,c){b=b.timestamp;return a.now()-b>=c?!1:!0}
function Hi(a){if(!a.s)throw Hh("retryQueuedRequests");a.C.Pa("QUEUED",a.s).then(function(b){b&&!Ki(a,b,a.Va)?a.J.K(function(){return z(function(c){if(1==c.h)return void 0===b.id?c.o(2):y(c,a.C.Ga(b.id,a.s),2);Hi(a);c.h=0})}):a.F.D()&&a.ja()})}
function Ji(a,b){a.bb&&!a.F.D()?a.bb(b):a.handleError(b)}
function Mi(a){var b;return(a=null===(b=null===a||void 0===a?void 0:a.error)||void 0===b?void 0:b.code)&&400<=a&&599>=a?!1:!0}
;var Ni=C("ytPubsub2Pubsub2Instance")||new L;L.prototype.subscribe=L.prototype.subscribe;L.prototype.unsubscribeByKey=L.prototype.ka;L.prototype.publish=L.prototype.ba;L.prototype.clear=L.prototype.clear;E("ytPubsub2Pubsub2Instance",Ni);E("ytPubsub2Pubsub2SubscribedKeys",C("ytPubsub2Pubsub2SubscribedKeys")||{});E("ytPubsub2Pubsub2TopicToKeys",C("ytPubsub2Pubsub2TopicToKeys")||{});E("ytPubsub2Pubsub2IsAsync",C("ytPubsub2Pubsub2IsAsync")||{});E("ytPubsub2Pubsub2SkipSubKey",null);function Oi(a,b){ji.call(this,a,b);this.options=b;yh(a)}
w(Oi,ji);function Pi(a,b){var c;return function(){c||(c=new Oi(a,b));return c}}
Oi.prototype.j=function(a,b,c){c=void 0===c?{}:c;return(this.options.Ha?Ai:zi)(a,b,Object.assign({},c))};
Oi.prototype.delete=function(a){a=void 0===a?{}:a;return(this.options.Ha?Ei:Bi)(this.name,a)};
function Qi(a,b){return Pi(a,b)}
;var Ri;
function Si(){if(Ri)return Ri();var a={};Ri=Qi("LogsDatabaseV2",{ha:(a.LogsRequestsStore={ya:2},a),Ha:!1,upgrade:function(b,c,d){c(2)&&Th(b,"LogsRequestsStore",{keyPath:"id",autoIncrement:!0});c(3);c(5)&&(d=d.objectStore("LogsRequestsStore"),d.h.indexNames.contains("newRequest")&&d.h.deleteIndex("newRequest"),d.h.createIndex("newRequestV2",["status","interface","timestamp"],{unique:!1}));c(7)&&b.h.objectStoreNames.contains("sapisid")&&b.h.deleteObjectStore("sapisid");c(9)&&b.h.objectStoreNames.contains("SWHealthLog")&&b.h.deleteObjectStore("SWHealthLog")},
version:9});return Ri()}
;function Ti(a){return li(Si(),a)}
function Ui(a,b){var c,d,e,f;return z(function(g){if(1==g.h)return c={startTime:P(),transactionType:"YT_IDB_TRANSACTION_TYPE_WRITE"},y(g,Ti(b),2);if(3!=g.h)return d=g.i,e=Object.assign(Object.assign({},a),{options:JSON.parse(JSON.stringify(a.options)),interface:N("INNERTUBE_CONTEXT_CLIENT_NAME",0)}),y(g,Vh(d,e),3);f=g.i;c.vb=P();Vi(c);return g.return(f)})}
function Wi(a,b){var c,d,e,f,g,h,k;return z(function(l){if(1==l.h)return c={startTime:P(),transactionType:"YT_IDB_TRANSACTION_TYPE_READ"},y(l,Ti(b),2);if(3!=l.h)return d=l.i,e=N("INNERTUBE_CONTEXT_CLIENT_NAME",0),f=[a,e,0],g=[a,e,P()],h=IDBKeyRange.bound(f,g),k=void 0,y(l,W(d,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(n){return di(n.objectStore("LogsRequestsStore").index("newRequestV2"),{query:h,direction:"prev"},function(p){p.cursor.value&&(k=p.cursor.value,"NEW"===a&&(k.status="QUEUED",
p.update(k)))})}),3);
c.vb=P();Vi(c);return l.return(k)})}
function Xi(a,b){var c;return z(function(d){if(1==d.h)return y(d,Ti(b),2);c=d.i;return d.return(W(c,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(e){var f=e.objectStore("LogsRequestsStore");return f.get(a).then(function(g){if(g)return g.status="QUEUED",V(f.h.put(g,void 0)).then(function(){return g})})}))})}
function Yi(a,b,c){c=void 0===c?!0:c;var d;return z(function(e){if(1==e.h)return y(e,Ti(b),2);d=e.i;return e.return(W(d,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(f){var g=f.objectStore("LogsRequestsStore");return g.get(a).then(function(h){return h?(h.status="NEW",c&&(h.sendCount+=1),V(g.h.put(h,void 0)).then(function(){return h})):U.resolve(void 0)})}))})}
function Zi(a,b){var c;return z(function(d){if(1==d.h)return y(d,Ti(b),2);c=d.i;return d.return(c.delete("LogsRequestsStore",a))})}
function $i(a){var b,c;return z(function(d){if(1==d.h)return y(d,Ti(a),2);b=d.i;c=P()-2592E6;return y(d,W(b,["LogsRequestsStore"],{mode:"readwrite",G:!0},function(e){return ai(e.objectStore("LogsRequestsStore"),{},function(f){if(f.cursor.value.timestamp<=c)return f.delete().then(function(){return f.continue()})})}),0)})}
function aj(){z(function(a){return y(a,Di(),0)})}
function Vi(a){if(!O("nwl_csi_killswitch")&&.01>=Math.random()){var b=C("ytPubsub2Pubsub2Instance");b&&b.publish.call(b,"nwl_transaction_latency_payload".toString(),"nwl_transaction_latency_payload",a)}}
;var bj={},cj=Qi("ServiceWorkerLogsDatabase",{ha:(bj.SWHealthLog={ya:1},bj),Ha:!0,upgrade:function(a,b){b(1)&&Th(a,"SWHealthLog",{keyPath:"id",autoIncrement:!0}).h.createIndex("swHealthNewRequest",["interface","timestamp"],{unique:!1})},
version:1});function dj(a){return li(cj(),a)}
function ej(a){var b,c;z(function(d){if(1==d.h)return y(d,dj(a),2);b=d.i;c=P()-2592E6;return y(d,W(b,["SWHealthLog"],{mode:"readwrite",G:!0},function(e){return ai(e.objectStore("SWHealthLog"),{},function(f){if(f.cursor.value.timestamp<=c)return f.delete().then(function(){return f.continue()})})}),0)})}
function fj(a){var b;return z(function(c){if(1==c.h)return y(c,dj(a),2);b=c.i;return y(c,b.clear("SWHealthLog"),0)})}
;var hj;function ij(){hj||(hj=new jh("yt.offline"));return hj}
function jj(a){if(O("offline_error_handling")){var b=ij().get("errors",!0)||{};b[a.message]={name:a.name,stack:a.stack};a.level&&(b[a.message].level=a.level);ij().set("errors",b,2592E3,!0)}}
function kj(){if(O("offline_error_handling")){var a=ij().get("errors",!0);if(a){for(var b in a)if(a[b]){var c=new vh(b,"sent via offline_errors");c.name=a[b].name;c.stack=a[b].stack;c.level=a[b].level;yf(c)}ij().set("errors",{},2592E3,!0)}}}
;var lj=Uf("network_polling_interval",3E4);function X(){I.call(this);this.N=0;this.la=this.m=!1;this.j=this.Aa();O("use_shared_nsm")?(Rd.h||(Rd.h=new Rd(cg)),this.i=Rd.h):(mj(this),nj(this))}
w(X,I);function oj(){if(!X.h){var a=C("yt.networkStatusManager.instance")||new X;E("yt.networkStatusManager.instance",a);X.h=a}return X.h}
m=X.prototype;m.D=function(){var a;return O("use_shared_nsm")&&this.i?null===(a=this.i)||void 0===a?void 0:a.D():this.j};
m.V=function(a){var b;O("use_shared_nsm")&&this.i?null===(b=this.i)||void 0===b?void 0:b.i=a:a!==this.j&&(this.j=a)};
m.sb=function(a){!O("use_shared_nsm")&&(this.m=!0,void 0===a?0:a)&&(this.N||pj(this))};
m.Aa=function(){var a=window.navigator.onLine;return void 0===a?!0:a};
m.kb=function(){this.la=!0};
m.X=function(a,b){return O("use_shared_nsm")&&this.i?this.i.X(a,b):I.prototype.X.call(this,a,b)};
function nj(a){window.addEventListener("online",function(){return z(function(b){if(1==b.h)return y(b,a.R(),2);a.la&&kj();b.h=0})})}
function mj(a){window.addEventListener("offline",function(){return z(function(b){return y(b,a.R(),0)})})}
function pj(a){a.N=Yf(function(){return z(function(b){if(1==b.h)return a.j?a.Aa()||!a.m?b.o(3):y(b,a.R(),3):y(b,a.R(),3);pj(a);b.h=0})},lj)}
m.R=function(a){var b=this;return O("use_shared_nsm")&&this.i?Sd(this.i,a):this.u?this.u:this.u=new Promise(function(c){var d,e,f;return z(function(g){switch(g.h){case 1:return d=window.AbortController?new window.AbortController:void 0,e=null===d||void 0===d?void 0:d.signal,f=!1,sa(g,2,3),d&&(b.A=cg.K(function(){d.abort()},a||2E4)),y(g,fetch("/generate_204",{method:"HEAD",
signal:e}),5);case 5:f=!0;case 3:va(g);b.u=void 0;b.A&&cg.W(b.A);f!==b.j&&(b.j=f,b.j&&b.m?Pd(b,"ytnetworkstatus-online"):b.m&&Pd(b,"ytnetworkstatus-offline"));c(f);wa(g);break;case 2:ua(g),f=!1,g.o(3)}})})};
X.prototype.sendNetworkCheckRequest=X.prototype.R;X.prototype.listen=X.prototype.X;X.prototype.enableErrorFlushing=X.prototype.kb;X.prototype.getWindowStatus=X.prototype.Aa;X.prototype.monitorNetworkStatusChange=X.prototype.sb;X.prototype.networkStatusHint=X.prototype.V;X.prototype.isNetworkAvailable=X.prototype.D;X.getInstance=oj;function qj(a){a=void 0===a?{}:a;I.call(this);var b=this;this.j=this.N=0;this.m="ytnetworkstatus-offline";this.u="ytnetworkstatus-online";O("use_shared_nsm")&&(this.m="networkstatus-offline",this.u="networkstatus-online");this.i=oj();var c=C("yt.networkStatusManager.instance.monitorNetworkStatusChange").bind(this.i);c&&c(a.Ma);a.ra&&!O("use_shared_nsm")&&(c=C("yt.networkStatusManager.instance.enableErrorFlushing").bind(this.i))&&c();if(c=C("yt.networkStatusManager.instance.listen").bind(this.i))a.va?
(this.va=a.va,c(this.u,function(){rj(b,"publicytnetworkstatus-online");O("use_shared_nsm")&&a.ra&&kj()}),c(this.m,function(){rj(b,"publicytnetworkstatus-offline")})):(c(this.u,function(){Pd(b,"publicytnetworkstatus-online");
O("use_shared_nsm")&&a.ra&&kj()}),c(this.m,function(){Pd(b,"publicytnetworkstatus-offline")}))}
w(qj,I);qj.prototype.D=function(){var a=C("yt.networkStatusManager.instance.isNetworkAvailable").bind(this.i);return a?a():!0};
qj.prototype.V=function(a){var b=C("yt.networkStatusManager.instance.networkStatusHint").bind(this.i);b&&b(a)};
qj.prototype.R=function(a){var b=this,c;return z(function(d){return(c=C("yt.networkStatusManager.instance.sendNetworkCheckRequest").bind(b.i))?d.return(c(a)):d.return(!0)})};
function rj(a,b){a.va?a.j?(cg.W(a.N),a.N=cg.K(function(){a.A!==b&&(Pd(a,b),a.A=b,a.j=P())},a.va-(P()-a.j))):(Pd(a,b),a.A=b,a.j=P()):Pd(a,b)}
;var sj;function tj(){Fi.call(this,{C:{ib:$i,Z:Zi,Pa:Wi,rb:Xi,Ga:Yi,set:Ui},F:uj(),handleError:yf,aa:zf,P:vj,now:P,bb:jj,J:bg(),Fa:"publicytnetworkstatus-online",Ea:"publicytnetworkstatus-offline",pa:!0,oa:.1,ta:Uf("potential_esf_error_limit",10),B:O,da:!wh()});this.pa&&Math.random()<=this.oa&&this.s&&ej(this.s);O("networkless_immediately_drop_sw_health_store")&&wj(this);O("networkless_immediately_drop_all_requests")&&aj();Ei("LogsDatabaseV2")}
w(tj,Fi);function xj(){var a=C("yt.networklessRequestController.instance");a||(a=new tj,E("yt.networklessRequestController.instance",a),O("networkless_logging")&&wi().then(function(b){a.s=b;Gi(a)}));
return a}
tj.prototype.writeThenSend=function(a,b){b||(b={});wh()||(this.h=!1);Fi.prototype.writeThenSend.call(this,a,b)};
tj.prototype.sendThenWrite=function(a,b,c){b||(b={});wh()||(this.h=!1);Fi.prototype.sendThenWrite.call(this,a,b,c)};
tj.prototype.sendAndWrite=function(a,b){b||(b={});wh()||(this.h=!1);Fi.prototype.sendAndWrite.call(this,a,b)};
function wj(a){var b;z(function(c){if(!a.s)throw b=Hh("clearSWHealthLogsDb"),b;return c.return(fj(a.s).catch(function(d){a.handleError(d)}))})}
function vj(a,b,c){var d;if(null===(d=b.postParams)||void 0===d?0:d.requestTimeMs)b.postParams.requestTimeMs=Math.round(P());c&&0===Object.keys(b).length?yg(a):mg(a,b)}
function uj(){sj||(sj=new qj({ra:!0,Ma:!0}));return sj}
;var yj=0,zj=0,Aj,Bj=B.ytNetworklessLoggingInitializationOptions||{isNwlInitialized:!1,potentialEsfErrorCounter:zj};E("ytNetworklessLoggingInitializationOptions",Bj);function Cj(a,b){function c(d){var e=Dj().D();if(!Ej()||!d||e&&O("vss_networkless_bypass_write"))Fj(a,b);else{var f={url:a,options:b,timestamp:P(),status:"NEW",sendCount:0};Ui(f,d).then(function(g){f.id=g;Dj().D()&&Gj(f)}).catch(function(g){Gj(f);
Dj().D()?yf(g):jj(g)})}}
b=void 0===b?{}:b;O("skip_is_supported_killswitch")?wi().then(function(d){c(d)}):c(vi())}
function Hj(a,b){function c(d){if(Ej()&&d){var e={url:a,options:b,timestamp:P(),status:"NEW",sendCount:0},f=!1,g=b.onSuccess?b.onSuccess:function(){};
e.options.onSuccess=function(h,k){void 0!==e.id?Zi(e.id,d):f=!0;O("vss_network_hint")&&Dj().V(!0);g(h,k)};
Fj(e.url,e.options);Ui(e,d).then(function(h){e.id=h;f&&Zi(e.id,d)}).catch(function(h){Dj().D()?yf(h):jj(h)})}else Fj(a,b)}
b=void 0===b?{}:b;O("skip_is_supported_killswitch")?wi().then(function(d){c(d)}):c(vi())}
function Ij(){var a=vi();if(!a)throw Hh("throttleSend");yj||(yj=cg.K(function(){var b;return z(function(c){if(1==c.h)return y(c,Wi("NEW",a),2);if(3!=c.h)return b=c.i,b?y(c,Gj(b),3):(cg.W(yj),yj=0,c.return());yj&&(yj=0,Ij());c.h=0})},100))}
function Gj(a){var b,c,d;return z(function(e){switch(e.h){case 1:b=vi();if(!b)throw c=Hh("immediateSend"),c;if(void 0===a.id){e.o(2);break}return y(e,Xi(a.id,b),3);case 3:(d=e.i)?a=d:zf(Error("The request cannot be found in the database."));case 2:var f=a.timestamp;if(!(2592E6<=P()-f)){e.o(4);break}zf(Error("Networkless Logging: Stored logs request expired age limit"));if(void 0===a.id){e.o(5);break}return y(e,Zi(a.id,b),5);case 5:return e.return();case 4:a.skipRetry||(a=Jj(a));f=a;var g,h;if(null===
(h=null===(g=null===f||void 0===f?void 0:f.options)||void 0===g?void 0:g.postParams)||void 0===h?0:h.requestTimeMs)f.options.postParams.requestTimeMs=Math.round(P());a=f;if(!a){e.o(0);break}if(!a.skipRetry||void 0===a.id){e.o(8);break}return y(e,Zi(a.id,b),8);case 8:Fj(a.url,a.options,!!a.skipRetry),e.h=0}})}
function Jj(a){var b=vi();if(!b)throw Hh("updateRequestHandlers");var c=a.options.onError?a.options.onError:function(){};
a.options.onError=function(e,f){var g;return z(function(h){switch(h.h){case 1:g=Mi(f);if(!(O("nwl_consider_error_code")&&g||!O("nwl_consider_error_code")&&Kj()<=Uf("potential_esf_error_limit",10))){h.o(2);break}return y(h,Dj().R(),3);case 3:if(Dj().D()){h.o(2);break}c(e,f);if(!O("nwl_consider_error_code")||void 0===(null===a||void 0===a?void 0:a.id)){h.o(5);break}return y(h,Yi(a.id,b,!1),5);case 5:return h.return();case 2:if(O("nwl_consider_error_code")&&!g&&Kj()>Uf("potential_esf_error_limit",10))return h.return();
C("ytNetworklessLoggingInitializationOptions")&&Bj.potentialEsfErrorCounter++;zj++;if(void 0===(null===a||void 0===a?void 0:a.id)){h.o(7);break}return 1>a.sendCount?y(h,Yi(a.id,b),11):y(h,Zi(a.id,b),7);case 11:cg.K(function(){Dj().D()&&Ij()},5E3);
case 7:c(e,f),h.h=0}})};
var d=a.options.onSuccess?a.options.onSuccess:function(){};
a.options.onSuccess=function(e,f){return z(function(g){if(1==g.h)return void 0===(null===a||void 0===a?void 0:a.id)?g.o(2):y(g,Zi(a.id,b),2);O("vss_network_hint")&&Dj().V(!0);d(e,f);g.h=0})};
return a}
function Dj(){if(O("use_new_nwl"))return uj();Aj||(Aj=new qj({ra:!0,Ma:!0}));return Aj}
function Fj(a,b,c){c&&0===Object.keys(b).length?yg(a):mg(a,b)}
function Ej(){return C("ytNetworklessLoggingInitializationOptions")?Bj.isNwlInitialized:!1}
function Kj(){return C("ytNetworklessLoggingInitializationOptions")?Bj.potentialEsfErrorCounter:zj}
;function Lj(a){var b=this;this.config_=null;a?this.config_=a:gh()&&(this.config_=Xg());Yf(function(){oh(b)},5E3)}
Lj.prototype.isReady=function(){!this.config_&&gh()&&(this.config_=Xg());return!!this.config_};
function $g(a,b,c,d){function e(v){v=void 0===v?!1:v;var x;if(d.retry&&"www.youtube-nocookie.com"!=h&&(v||O("skip_ls_gel_retry")||(x=mh(b,c,l,k)),x)){var A=g.onSuccess,J=g.onFetchSuccess;g.onSuccess=function(K,M){nh(x);A(K,M)};
c.onFetchSuccess=function(K,M){nh(x);J(K,M)}}try{v&&d.retry&&!d.Ta.bypassNetworkless?(g.method="POST",d.Ta.writeThenSend?O("use_new_nwl")?xj().writeThenSend(q,g):Cj(q,g):O("use_new_nwl")?xj().sendAndWrite(q,g):Hj(q,g)):(g.method="POST",g.postParams||(g.postParams={}),mg(q,g))}catch(K){if("InvalidAccessError"==K.name)x&&(nh(x),x=0),zf(Error("An extension is blocking network request."));
else throw K;}x&&Yf(function(){oh(a)},5E3)}
!N("VISITOR_DATA")&&"visitor_id"!==b&&.01>Math.random()&&zf(new vh("Missing VISITOR_DATA when sending innertube request.",b,c,d));if(!a.isReady()){var f=new vh("innertube xhrclient not ready",b,c,d);yf(f);throw f;}var g={headers:{"Content-Type":"application/json"},method:"POST",postParams:c,postBodyFormat:"JSON",onTimeout:function(){d.onTimeout()},
onFetchTimeout:d.onTimeout,onSuccess:function(v,x){if(d.onSuccess)d.onSuccess(x)},
onFetchSuccess:function(v){if(d.onSuccess)d.onSuccess(v)},
onError:function(v,x){if(d.onError)d.onError(x)},
onFetchError:function(v){if(d.onError)d.onError(v)},
timeout:d.timeout,withCredentials:!0},h="";(f=a.config_.ob)&&(h=f);var k=a.config_.qb||!1,l=hh(k,h,d);Object.assign(g.headers,l);(f=g.headers.Authorization)&&!h&&(g.headers["x-origin"]=window.location.origin);var n="/youtubei/"+a.config_.innertubeApiVersion+"/"+b,p={alt:"json"},u=a.config_.pb&&f;O("omit_innertube_api_key_for_bearer_auth_header")&&(u=u&&f.startsWith("Bearer"));u||(p.key=a.config_.innertubeApiKey);var q=Rf(""+h+n,p||{},!0);O("use_new_nwl")||Ej()?ui().then(function(v){e(v)}):e(!1)}
;function Mj(a,b){var c=void 0===c?{}:c;var d=Lj;N("ytLoggingEventsDefaultDisabled",!1)&&Lj==Lj&&(d=null);a:{c=void 0===c?{}:c;if(O("lr_drop_other_and_business_payloads")){if(Wf[a]||Vf[a])break a}else if(O("lr_drop_other_payloads")&&Wf[a])break a;var e={},f=Math.round(c.timestamp||P());e.eventTimeMs=f<Number.MAX_SAFE_INTEGER?f:0;e[a]=b;a=C("_lact",window);a=null==a?-1:Math.max(Date.now()-a,0);e.context={lastActivityMs:String(c.timestamp||!isFinite(a)?-1:a)};O("log_sequence_info_on_gel_web")&&c.Za&&
(a=e.context,b=c.Za,bh[b]=b in bh?bh[b]+1:0,a.sequence={index:bh[b],groupKey:b},c.Lb&&delete bh[c.Za]);(c.Sb?Ug:Qg)({endpoint:"log_event",payload:e,ca:c.ca,za:c.za},d)}}
;var Nj=[{Da:function(a){return"Cannot read property '"+a.key+"'"},
sa:{Error:[{regexp:/(Permission denied) to access property "([^']+)"/,groups:["reason","key"]}],TypeError:[{regexp:/Cannot read property '([^']+)' of (null|undefined)/,groups:["key","value"]},{regexp:/\u65e0\u6cd5\u83b7\u53d6\u672a\u5b9a\u4e49\u6216 (null|undefined) \u5f15\u7528\u7684\u5c5e\u6027\u201c([^\u201d]+)\u201d/,groups:["value","key"]},{regexp:/\uc815\uc758\ub418\uc9c0 \uc54a\uc74c \ub610\ub294 (null|undefined) \ucc38\uc870\uc778 '([^']+)' \uc18d\uc131\uc744 \uac00\uc838\uc62c \uc218 \uc5c6\uc2b5\ub2c8\ub2e4./,
groups:["value","key"]},{regexp:/No se puede obtener la propiedad '([^']+)' de referencia nula o sin definir/,groups:["key"]},{regexp:/Unable to get property '([^']+)' of (undefined or null) reference/,groups:["key","value"]},{regexp:/(null) is not an object \(evaluating '(?:([^.]+)\.)?([^']+)'\)/,groups:["value","base","key"]}]}},{Da:function(a){return"Cannot call '"+a.key+"'"},
sa:{TypeError:[{regexp:/(?:([^ ]+)?\.)?([^ ]+) is not a function/,groups:["base","key"]},{regexp:/([^ ]+) called on (null or undefined)/,groups:["key","value"]},{regexp:/Object (.*) has no method '([^ ]+)'/,groups:["base","key"]},{regexp:/Object doesn't support property or method '([^ ]+)'/,groups:["key"]},{regexp:/\u30aa\u30d6\u30b8\u30a7\u30af\u30c8\u306f '([^']+)' \u30d7\u30ed\u30d1\u30c6\u30a3\u307e\u305f\u306f\u30e1\u30bd\u30c3\u30c9\u3092\u30b5\u30dd\u30fc\u30c8\u3057\u3066\u3044\u307e\u305b\u3093/,
groups:["key"]},{regexp:/\uac1c\uccb4\uac00 '([^']+)' \uc18d\uc131\uc774\ub098 \uba54\uc11c\ub4dc\ub97c \uc9c0\uc6d0\ud558\uc9c0 \uc54a\uc2b5\ub2c8\ub2e4./,groups:["key"]}]}},{Da:function(a){return a.key+" is not defined"},
sa:{ReferenceError:[{regexp:/(.*) is not defined/,groups:["key"]},{regexp:/Can't find variable: (.*)/,groups:["key"]}]}}];var Pj={U:[],T:[{gb:Oj,weight:500}]};function Oj(a){if("JavaException"===a.name)return!0;a=a.stack;return a.includes("chrome://")||a.includes("chrome-extension://")||a.includes("moz-extension://")}
;function Qj(){this.T=[];this.U=[]}
var Rj;function Sj(){if(!Rj){var a=Rj=new Qj;a.U.length=0;a.T.length=0;Pj.U&&a.U.push.apply(a.U,Pj.U);Pj.T&&a.T.push.apply(a.T,Pj.T)}return Rj}
;var Tj=new L;function Uj(a){function b(){return a.charCodeAt(d++)}
var c=a.length,d=0;do{var e=Vj(b);if(Infinity===e)break;var f=e>>3;switch(e&7){case 0:e=Vj(b);if(2===f)return e;break;case 1:if(2===f)return;d+=8;break;case 2:e=Vj(b);if(2===f)return a.substr(d,e);d+=e;break;case 5:if(2===f)return;d+=4;break;default:return}}while(d<c)}
function Vj(a){var b=a(),c=b&127;if(128>b)return c;b=a();c|=(b&127)<<7;if(128>b)return c;b=a();c|=(b&127)<<14;if(128>b)return c;b=a();return 128>b?c|(b&127)<<21:Infinity}
;function Wj(a,b,c,d){if(a)if(Array.isArray(a)){var e=d;for(d=0;d<a.length&&!(a[d]&&(e+=Xj(d,a[d],b,c),500<e));d++);d=e}else if("object"===typeof a)for(e in a){if(a[e]){var f=a[e];var g=b;var h=c;g="string"!==typeof f||"clickTrackingParams"!==e&&"trackingParams"!==e?0:(f=Uj(atob(f.replace(/-/g,"+").replace(/_/g,"/"))))?Xj(e+".ve",f,g,h):0;d+=g;d+=Xj(e,a[e],b,c);if(500<d)break}}else c[b]=Yj(a),d+=c[b].length;else c[b]=Yj(a),d+=c[b].length;return d}
function Xj(a,b,c,d){c+="."+a;a=Yj(b);d[c]=a;return c.length+a.length}
function Yj(a){try{return("string"===typeof a?a:String(JSON.stringify(a))).substr(0,500)}catch(b){return"unable to serialize "+typeof a+" ("+b.message+")"}}
;var Zj=new Set,ak=0,bk=0,ck=0,dk=[],ek=["PhantomJS","Googlebot","TO STOP THIS SECURITY SCAN go/scan"];var fk={};function gk(a){return fk[a]||(fk[a]=String(a).replace(/\-([a-z])/g,function(b,c){return c.toUpperCase()}))}
;var hk={},ik=[],Ue=new L,jk={};function kk(){for(var a=t(ik),b=a.next();!b.done;b=a.next())b=b.value,b()}
function lk(a,b){var c;"yt:"===a.tagName.toLowerCase().substr(0,3)?c=a.getAttribute(b):c=a?a.dataset?a.dataset[gk(b)]:a.getAttribute("data-"+b):null;return c}
function mk(a){Ue.ba.apply(Ue,arguments)}
;function nk(a){this.h=a||{};a=[this.h,window.YTConfig||{}];for(var b=0;b<a.length;b++)a[b].host&&(a[b].host=a[b].host.toString().replace("http://","https://"))}
function Y(a,b){a=[a.h,window.YTConfig||{}];for(var c=0;c<a.length;c++){var d=a[c][b];if(void 0!==d)return d}return null}
function ok(a,b,c){pk||(pk={},Hf(window,"message",function(d){a:{if(d.origin===Y(a,"host")){try{var e=JSON.parse(d.data)}catch(f){e=void 0;break a}if(d=pk[e.id])d.u=!0,d.u&&(G(d.v,d.sendMessage,d),d.v.length=0),d.Ia(e)}e=void 0}return e}));
pk[c]=b}
var pk=null;function qk(a,b,c){this.m=this.h=this.i=null;this.j=0;this.u=!1;this.v=[];this.l=null;this.H={};if(!a)throw Error("YouTube player element ID required.");this.id=La(this);this.A=c;this.setup(a,b)}
m=qk.prototype;m.setSize=function(a,b){this.h.width=a.toString();this.h.height=b.toString();return this};
m.getIframe=function(){return this.h};
m.Ia=function(a){rk(this,a.event,a)};
m.addEventListener=function(a,b){var c=b;"string"===typeof b&&(c=function(){window[b].apply(window,arguments)});
if(!c)return this;this.l.subscribe(a,c);sk(this,a);return this};
function tk(a,b){b=b.split(".");if(2===b.length){var c=b[1];a.A===b[0]&&sk(a,c)}}
m.destroy=function(){this.h&&this.h.id&&(hk[this.h.id]=null);(0,jd)(this.l);if(this.m){var a=this.h,b=a.parentNode;b&&b.replaceChild(this.m,a)}else(a=this.h)&&a.parentNode&&a.parentNode.removeChild(a);pk&&(pk[this.id]=null);this.i=null;a=this.h;for(var c in db)db[c][0]==a&&Ff(c);this.m=this.h=null};
m.La=function(){return{}};
function uk(a,b,c){c=c||[];c=Array.prototype.slice.call(c);b={event:"command",func:b,args:c};a.u?a.sendMessage(b):a.v.push(b)}
function rk(a,b,c){a.l.l||(c={target:a,data:c},a.l.ba(b,c),mk(a.A+"."+b,c))}
function vk(a,b){var c=document.createElement("iframe");b=b.attributes;for(var d=0,e=b.length;d<e;d++){var f=b[d].value;null!=f&&""!==f&&"null"!==f&&c.setAttribute(b[d].name,f)}c.setAttribute("frameBorder","0");c.setAttribute("allowfullscreen","1");c.setAttribute("allow","accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");c.setAttribute("title","YouTube "+Y(a.i,"title"));(b=Y(a.i,"width"))&&c.setAttribute("width",b.toString());(b=Y(a.i,"height"))&&c.setAttribute("height",
b.toString());var g=a.La();g.enablejsapi=window.postMessage?1:0;window.location.host&&(g.origin=window.location.protocol+"//"+window.location.host);g.widgetid=a.id;window.location.href&&G(["debugjs","debugcss"],function(h){var k=Qb(window.location.href,h);null!==k&&(g[h]=k)});
window.yt_embedsTokenValue&&(g.embedsTokenValue=encodeURIComponent(window.yt_embedsTokenValue),delete window.yt_embedsTokenValue);c.src=Y(a.i,"host")+("/embed/"+Y(a.i,"videoId"))+"?"+Ob(g);return c}
m.Ua=function(){this.h&&this.h.contentWindow?this.sendMessage({event:"listening"}):window.clearInterval(this.j)};
function wk(a){ok(a.i,a,a.id);a.j=Jf(a.Ua.bind(a));Hf(a.h,"load",function(){window.clearInterval(a.j);a.j=Jf(a.Ua.bind(a))})}
m.setup=function(a,b){var c=document;if(a="string"===typeof a?c.getElementById(a):a)if(c="iframe"===a.tagName.toLowerCase(),b.host||(b.host=c?Mb(a.src):"https://www.youtube.com"),this.i=new nk(b),c||(b=vk(this,a),this.m=a,(c=a.parentNode)&&c.replaceChild(b,a),a=b),this.h=a,this.h.id||(this.h.id="widget"+La(this.h)),hk[this.h.id]=this,window.postMessage){this.l=new L;wk(this);b=Y(this.i,"events");for(var d in b)b.hasOwnProperty(d)&&this.addEventListener(d,b[d]);for(var e in jk)jk.hasOwnProperty(e)&&
tk(this,e)}};
function sk(a,b){a.H[b]||(a.H[b]=!0,uk(a,"addEventListener",[b]))}
m.sendMessage=function(a){a.id=this.id;a.channel="widget";a=Ce(a);var b=[Mb(this.h.src||"").replace("http:","https:")];if(this.h.contentWindow)for(var c=0;c<b.length;c++)try{this.h.contentWindow.postMessage(a,b[c])}catch(A){if(A.name&&"SyntaxError"===A.name){if(!(A.message&&0<A.message.indexOf("target origin ''"))){var d=void 0,e=A;d=void 0===d?{}:d;d.name=N("INNERTUBE_CONTEXT_CLIENT_NAME",1);d.version=N("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0);var f=d||{};d="WARNING";d=void 0===d?"ERROR":d;if(e){e.hasOwnProperty("level")&&
e.level&&(d=e.level);if(O("console_log_js_exceptions")){var g=e,h=[];h.push("Name: "+g.name);h.push("Message: "+g.message);g.hasOwnProperty("params")&&h.push("Error Params: "+JSON.stringify(g.params));g.hasOwnProperty("args")&&h.push("Error args: "+JSON.stringify(g.args));h.push("File name: "+g.fileName);h.push("Stacktrace: "+g.stack);window.console.log(h.join("\n"),g)}if(!(5<=ak)){g=void 0;var k=f,l=md(e);f=l.message||"Unknown Error";h=l.name||"UnknownError";var n=l.stack||e.i||"Not available";if(n.startsWith(h+
": "+f)){var p=n.split("\n");p.shift();n=p.join("\n")}p=l.lineNumber||"Not available";l=l.fileName||"Not available";var u=0;if(e.hasOwnProperty("args")&&e.args&&e.args.length)for(g=0;g<e.args.length&&!(u=Wj(e.args[g],"params."+g,k,u),500<=u);g++);else if(e.hasOwnProperty("params")&&e.params){var q=e.params;if("object"===typeof e.params)for(g in q){if(q[g]){var v="params."+g,x=Yj(q[g]);k[v]=x;u+=v.length+x.length;if(500<u)break}}else k.params=Yj(q)}if(dk.length)for(g=0;g<dk.length&&!(u=Wj(dk[g],"params.context."+
g,k,u),500<=u);g++);navigator.vendor&&!k.hasOwnProperty("vendor")&&(k["device.vendor"]=navigator.vendor);g={message:f,name:h,lineNumber:p,fileName:l,stack:n,params:k,sampleWeight:1};f=Number(e.columnNumber);isNaN(f)||(g.lineNumber=g.lineNumber+":"+f);if("IGNORED"===e.level)e=0;else a:{e=Sj();f=t(e.U);for(h=f.next();!h.done;h=f.next())if(h=h.value,g.message&&g.message.match(h.Pb)){e=h.weight;break a}e=t(e.T);for(f=e.next();!f.done;f=e.next())if(f=f.value,f.gb(g)){e=f.weight;break a}e=1}g.sampleWeight=
e;e=g;g=t(Nj);for(f=g.next();!f.done;f=g.next())if(f=f.value,f.sa[e.name])for(p=t(f.sa[e.name]),h=p.next();!h.done;h=p.next())if(l=h.value,h=e.message.match(l.regexp)){e.params["params.error.original"]=h[0];p=l.groups;l={};for(n=0;n<p.length;n++)l[p[n]]=h[n+1],e.params["params.error."+p[n]]=h[n+1];e.message=f.Da(l);break}e.params||(e.params={});g=Sj();e.params["params.errorServiceSignature"]="msg="+g.U.length+"&cb="+g.T.length;e.params["params.serviceWorker"]="false";B.document&&B.document.querySelectorAll&&
(e.params["params.fscripts"]=String(document.querySelectorAll("script:not([nonce])").length));lb("sample").constructor!==jb&&(e.params["params.fconst"]="true");window.yterr&&"function"===typeof window.yterr&&window.yterr(e);if(0!==e.sampleWeight&&!Zj.has(e.message)){"ERROR"===d?(Tj.ba("handleError",e),O("record_app_crashed_web")&&0===ck&&1===e.sampleWeight&&(ck++,Mj("appCrashed",{appCrashType:"APP_CRASH_TYPE_BREAKPAD"})),bk++):"WARNING"===d&&Tj.ba("handleWarning",e);if(O("kevlar_gel_error_routing")){g=
d;h=e;b:{f=t(ek);for(p=f.next();!p.done;p=f.next())if(vg(p.value.toLowerCase())){f=!0;break b}f=!1}if(f)f=void 0;else{p={stackTrace:h.stack};h.fileName&&(p.filename=h.fileName);f=h.lineNumber&&h.lineNumber.split?h.lineNumber.split(":"):[];0!==f.length&&(1!==f.length||isNaN(Number(f[0]))?2!==f.length||isNaN(Number(f[0]))||isNaN(Number(f[1]))||(p.lineNumber=Number(f[0]),p.columnNumber=Number(f[1])):p.lineNumber=Number(f[0]));f={level:"ERROR_LEVEL_UNKNOWN",message:h.message,errorClassName:h.name,sampleWeight:h.sampleWeight};
"ERROR"===g?f.level="ERROR_LEVEL_ERROR":"WARNING"===g&&(f.level="ERROR_LEVEL_WARNNING");p={isObfuscated:!0,browserStackInfo:p};l={pageUrl:window.location.href,kvPairs:[]};N("FEXP_EXPERIMENTS")&&(l.experimentIds=N("FEXP_EXPERIMENTS"));n=uf();k=(k=qf.EXPERIMENT_FLAGS)?k.web_disable_gel_stp_ecatcher_killswitch:void 0;if(!k&&n)for(u=t(Object.keys(n)),k=u.next();!k.done;k=u.next())k=k.value,l.kvPairs.push({key:k,value:String(n[k])});if(h=h.params)for(n=t(Object.keys(h)),k=n.next();!k.done;k=n.next())k=
k.value,l.kvPairs.push({key:"client."+k,value:String(h[k])});h=N("SERVER_NAME",void 0);n=N("SERVER_VERSION",void 0);h&&n&&(l.kvPairs.push({key:"server.name",value:h}),l.kvPairs.push({key:"server.version",value:n}));f={errorMetadata:l,stackTrace:p,logMessage:f}}f&&(Mj("clientError",f),("ERROR"===g||O("errors_flush_gel_always_killswitch"))&&Sg())}if(!O("suppress_error_204_logging")){f=e;g=f.params||{};d={urlParams:{a:"logerror",t:"jserror",type:f.name,msg:f.message.substr(0,250),line:f.lineNumber,level:d,
"client.name":g.name},postParams:{url:N("PAGE_NAME",window.location.href),file:f.fileName},method:"POST"};g.version&&(d["client.version"]=g.version);if(d.postParams){f.stack&&(d.postParams.stack=f.stack);f=t(Object.keys(g));for(h=f.next();!h.done;h=f.next())h=h.value,d.postParams["client."+h]=g[h];if(g=uf())for(f=t(Object.keys(g)),h=f.next();!h.done;h=f.next())h=h.value,d.postParams[h]=g[h];g=N("SERVER_NAME",void 0);f=N("SERVER_VERSION",void 0);g&&f&&(d.postParams["server.name"]=g,d.postParams["server.version"]=
f)}mg(N("ECATCHER_REPORT_HOST","")+"/error_204",d)}try{Zj.add(e.message)}catch(J){}ak++}}}}}else throw A;}else console&&console.warn&&console.warn("The YouTube player is not attached to the DOM. API calls should be made after the onReady event. See more: https://developers.google.com/youtube/iframe_api_reference#Events")};function xk(a){return(0===a.search("cue")||0===a.search("load"))&&"loadModule"!==a}
function yk(a){return 0===a.search("get")||0===a.search("is")}
;function zk(a,b){qk.call(this,a,Object.assign({title:"video player",videoId:"",width:640,height:360},b||{}),"player");this.L={};this.playerInfo={}}
w(zk,qk);m=zk.prototype;m.La=function(){var a=Y(this.i,"playerVars");if(a){var b={},c;for(c in a)b[c]=a[c];a=b}else a={};window!==window.top&&document.referrer&&(a.widget_referrer=document.referrer.substring(0,256));if(c=Y(this.i,"embedConfig")){if(D(c))try{c=JSON.stringify(c)}catch(d){console.error("Invalid embed config JSON",d)}a.embed_config=c}return a};
m.Ia=function(a){var b=a.event;a=a.info;switch(b){case "apiInfoDelivery":if(D(a))for(var c in a)a.hasOwnProperty(c)&&(this.L[c]=a[c]);break;case "infoDelivery":Ak(this,a);break;case "initialDelivery":D(a)&&(window.clearInterval(this.j),this.playerInfo={},this.L={},Bk(this,a.apiInterface),Ak(this,a));break;default:rk(this,b,a)}};
function Ak(a,b){if(D(b))for(var c in b)b.hasOwnProperty(c)&&(a.playerInfo[c]=b[c])}
function Bk(a,b){G(b,function(c){this[c]||("getCurrentTime"===c?this[c]=function(){var d=this.playerInfo.currentTime;if(1===this.playerInfo.playerState){var e=(Date.now()/1E3-this.playerInfo.currentTimeLastUpdated_)*this.playerInfo.playbackRate;0<e&&(d+=Math.min(e,1))}return d}:xk(c)?this[c]=function(){this.playerInfo={};
this.L={};uk(this,c,arguments);return this}:yk(c)?this[c]=function(){var d=0;
0===c.search("get")?d=3:0===c.search("is")&&(d=2);return this.playerInfo[c.charAt(d).toLowerCase()+c.substr(d+1)]}:this[c]=function(){uk(this,c,arguments);
return this})},a)}
m.getVideoEmbedCode=function(){var a=Y(this.i,"host")+("/embed/"+Y(this.i,"videoId")),b=Number(Y(this.i,"width")),c=Number(Y(this.i,"height"));if(isNaN(b)||isNaN(c))throw Error("Invalid width or height property");b=Math.floor(b);c=Math.floor(c);a=nb(a,void 0);return'<iframe width="'+b+'" height="'+c+'" src="'+a+'" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>'};
m.getOptions=function(a){return this.L.namespaces?a?this.L[a]?this.L[a].options||[]:[]:this.L.namespaces||[]:[]};
m.getOption=function(a,b){if(this.L.namespaces&&a&&b&&this.L[a])return this.L[a][b]};
function Ck(a){if("iframe"!==a.tagName.toLowerCase()){var b=lk(a,"videoid");b&&(b={videoId:b,width:lk(a,"width"),height:lk(a,"height")},new zk(a,b))}}
;E("YT.PlayerState.UNSTARTED",-1);E("YT.PlayerState.ENDED",0);E("YT.PlayerState.PLAYING",1);E("YT.PlayerState.PAUSED",2);E("YT.PlayerState.BUFFERING",3);E("YT.PlayerState.CUED",5);E("YT.get",function(a){return hk[a]});
E("YT.scan",kk);E("YT.subscribe",function(a,b,c){Ue.subscribe(a,b,c);jk[a]=!0;for(var d in hk)hk.hasOwnProperty(d)&&tk(hk[d],a)});
E("YT.unsubscribe",function(a,b,c){Te(a,b,c)});
E("YT.Player",zk);qk.prototype.destroy=qk.prototype.destroy;qk.prototype.setSize=qk.prototype.setSize;qk.prototype.getIframe=qk.prototype.getIframe;qk.prototype.addEventListener=qk.prototype.addEventListener;zk.prototype.getVideoEmbedCode=zk.prototype.getVideoEmbedCode;zk.prototype.getOptions=zk.prototype.getOptions;zk.prototype.getOption=zk.prototype.getOption;
ik.push(function(a){var b=a;b||(b=document);a=Za(b.getElementsByTagName("yt:player"));var c=b||document;if(c.querySelectorAll&&c.querySelector)b=c.querySelectorAll(".yt-player");else{var d;c=document;b=b||c;if(b.querySelectorAll&&b.querySelector)b=b.querySelectorAll(".yt-player");else if(b.getElementsByClassName){var e=b.getElementsByClassName("yt-player");b=e}else{e=b.getElementsByTagName("*");var f={};for(c=d=0;b=e[c];c++){var g=b.className,h;if(h="function"==typeof g.split)h=0<=Va(g.split(/\s+/),
"yt-player");h&&(f[d++]=b)}f.length=d;b=f}}b=Za(b);G(Ya(a,b),Ck)});
"undefined"!=typeof YTConfig&&YTConfig.parsetags&&"onload"!=YTConfig.parsetags||kk();var Dk=B.onYTReady;Dk&&Dk();var Ek=B.onYouTubeIframeAPIReady;Ek&&Ek();var Fk=B.onYouTubePlayerAPIReady;Fk&&Fk();}).call(this);
