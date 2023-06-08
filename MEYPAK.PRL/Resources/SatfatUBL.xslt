<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
xmlns:ccts="urn:un:unece:uncefact:documentation:2"
xmlns:clm54217="urn:un:unece:uncefact:codelist:specification:54217:2001"
xmlns:clm5639="urn:un:unece:uncefact:codelist:specification:5639:1988"
xmlns:clm66411="urn:un:unece:uncefact:codelist:specification:66411:2001"
xmlns:clmIANAMIMEMediaType="urn:un:unece:uncefact:codelist:specification:IANAMIMEMediaType:2003"
xmlns:fn="http://www.w3.org/2005/xpath-functions" xmlns:link="http://www.xbrl.org/2003/linkbase"
xmlns:n1="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"
xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
xmlns:xbrldi="http://xbrl.org/2006/xbrldi" xmlns:xbrli="http://www.xbrl.org/2003/instance"
xmlns:xdt="http://www.w3.org/2005/xpath-datatypes" xmlns:xlink="http://www.w3.org/1999/xlink"
xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:xsd="http://www.w3.org/2001/XMLSchema"
xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
exclude-result-prefixes="cac cbc ccts clm54217 clm5639 clm66411 clmIANAMIMEMediaType fn link n1 qdt udt xbrldi xbrli xdt xlink xs xsd xsi">
<xsl:decimal-format name="european" decimal-separator="," grouping-separator="." NaN=""/>
<xsl:output version="4.0" method="html" indent="no" encoding="UTF-8"
doctype-public="-//W3C//DTD HTML 4.01 Transitional//EN"
doctype-system="http://www.w3.org/TR/html4/loose.dtd"/>
<xsl:param name="SV_OutputFormat" select="'HTML'"/>
<xsl:variable name="XML" select="/"/>
<xsl:template match="/">
<html>
<head>
<title/>
        <script type="text/javascript">
          <![CDATA[var QRCode;!function(){function a(a){this.mode=c.MODE_8BIT_BYTE,this.data=a,this.parsedData=[];for(var b=[],d=0,e=this.data.length;e>d;d++){var f=this.data.charCodeAt(d);f>65536?(b[0]=240|(1835008&f)>>>18,b[1]=128|(258048&f)>>>12,b[2]=128|(4032&f)>>>6,b[3]=128|63&f):f>2048?(b[0]=224|(61440&f)>>>12,b[1]=128|(4032&f)>>>6,b[2]=128|63&f):f>128?(b[0]=192|(1984&f)>>>6,b[1]=128|63&f):b[0]=f,this.parsedData=this.parsedData.concat(b)}this.parsedData.length!=this.data.length&&(this.parsedData.unshift(191),this.parsedData.unshift(187),this.parsedData.unshift(239))}function b(a,b){this.typeNumber=a,this.errorCorrectLevel=b,this.modules=null,this.moduleCount=0,this.dataCache=null,this.dataList=[]}function i(a,b){if(void 0==a.length)throw new Error(a.length+"/"+b);for(var c=0;c<a.length&&0==a[c];)c++;this.num=new Array(a.length-c+b);for(var d=0;d<a.length-c;d++)this.num[d]=a[d+c]}function j(a,b){this.totalCount=a,this.dataCount=b}function k(){this.buffer=[],this.length=0}function m(){return"undefined"!=typeof CanvasRenderingContext2D}function n(){var a=!1,b=navigator.userAgent;return/android/i.test(b)&&(a=!0,aMat=b.toString().match(/android ([0-9]\.[0-9])/i),aMat&&aMat[1]&&(a=parseFloat(aMat[1]))),a}function r(a,b){for(var c=1,e=s(a),f=0,g=l.length;g>=f;f++){var h=0;switch(b){case d.L:h=l[f][0];break;case d.M:h=l[f][1];break;case d.Q:h=l[f][2];break;case d.H:h=l[f][3]}if(h>=e)break;c++}if(c>l.length)throw new Error("Too long data");return c}function s(a){var b=encodeURI(a).toString().replace(/\%[0-9a-fA-F]{2}/g,"a");return b.length+(b.length!=a?3:0)}a.prototype={getLength:function(){return this.parsedData.length},write:function(a){for(var b=0,c=this.parsedData.length;c>b;b++)a.put(this.parsedData[b],8)}},b.prototype={addData:function(b){var c=new a(b);this.dataList.push(c),this.dataCache=null},isDark:function(a,b){if(0>a||this.moduleCount<=a||0>b||this.moduleCount<=b)throw new Error(a+","+b);return this.modules[a][b]},getModuleCount:function(){return this.moduleCount},make:function(){this.makeImpl(!1,this.getBestMaskPattern())},makeImpl:function(a,c){this.moduleCount=4*this.typeNumber+17,this.modules=new Array(this.moduleCount);for(var d=0;d<this.moduleCount;d++){this.modules[d]=new Array(this.moduleCount);for(var e=0;e<this.moduleCount;e++)this.modules[d][e]=null}this.setupPositionProbePattern(0,0),this.setupPositionProbePattern(this.moduleCount-7,0),this.setupPositionProbePattern(0,this.moduleCount-7),this.setupPositionAdjustPattern(),this.setupTimingPattern(),this.setupTypeInfo(a,c),this.typeNumber>=7&&this.setupTypeNumber(a),null==this.dataCache&&(this.dataCache=b.createData(this.typeNumber,this.errorCorrectLevel,this.dataList)),this.mapData(this.dataCache,c)},setupPositionProbePattern:function(a,b){for(var c=-1;7>=c;c++)if(!(-1>=a+c||this.moduleCount<=a+c))for(var d=-1;7>=d;d++)-1>=b+d||this.moduleCount<=b+d||(this.modules[a+c][b+d]=c>=0&&6>=c&&(0==d||6==d)||d>=0&&6>=d&&(0==c||6==c)||c>=2&&4>=c&&d>=2&&4>=d?!0:!1)},getBestMaskPattern:function(){for(var a=0,b=0,c=0;8>c;c++){this.makeImpl(!0,c);var d=f.getLostPoint(this);(0==c||a>d)&&(a=d,b=c)}return b},createMovieClip:function(a,b,c){var d=a.createEmptyMovieClip(b,c),e=1;this.make();for(var f=0;f<this.modules.length;f++)for(var g=f*e,h=0;h<this.modules[f].length;h++){var i=h*e,j=this.modules[f][h];j&&(d.beginFill(0,100),d.moveTo(i,g),d.lineTo(i+e,g),d.lineTo(i+e,g+e),d.lineTo(i,g+e),d.endFill())}return d},setupTimingPattern:function(){for(var a=8;a<this.moduleCount-8;a++)null==this.modules[a][6]&&(this.modules[a][6]=0==a%2);for(var b=8;b<this.moduleCount-8;b++)null==this.modules[6][b]&&(this.modules[6][b]=0==b%2)},setupPositionAdjustPattern:function(){for(var a=f.getPatternPosition(this.typeNumber),b=0;b<a.length;b++)for(var c=0;c<a.length;c++){var d=a[b],e=a[c];if(null==this.modules[d][e])for(var g=-2;2>=g;g++)for(var h=-2;2>=h;h++)this.modules[d+g][e+h]=-2==g||2==g||-2==h||2==h||0==g&&0==h?!0:!1}},setupTypeNumber:function(a){for(var b=f.getBCHTypeNumber(this.typeNumber),c=0;18>c;c++){var d=!a&&1==(1&b>>c);this.modules[Math.floor(c/3)][c%3+this.moduleCount-8-3]=d}for(var c=0;18>c;c++){var d=!a&&1==(1&b>>c);this.modules[c%3+this.moduleCount-8-3][Math.floor(c/3)]=d}},setupTypeInfo:function(a,b){for(var c=this.errorCorrectLevel<<3|b,d=f.getBCHTypeInfo(c),e=0;15>e;e++){var g=!a&&1==(1&d>>e);6>e?this.modules[e][8]=g:8>e?this.modules[e+1][8]=g:this.modules[this.moduleCount-15+e][8]=g}for(var e=0;15>e;e++){var g=!a&&1==(1&d>>e);8>e?this.modules[8][this.moduleCount-e-1]=g:9>e?this.modules[8][15-e-1+1]=g:this.modules[8][15-e-1]=g}this.modules[this.moduleCount-8][8]=!a},mapData:function(a,b){for(var c=-1,d=this.moduleCount-1,e=7,g=0,h=this.moduleCount-1;h>0;h-=2)for(6==h&&h--;;){for(var i=0;2>i;i++)if(null==this.modules[d][h-i]){var j=!1;g<a.length&&(j=1==(1&a[g]>>>e));var k=f.getMask(b,d,h-i);k&&(j=!j),this.modules[d][h-i]=j,e--,-1==e&&(g++,e=7)}if(d+=c,0>d||this.moduleCount<=d){d-=c,c=-c;break}}}},b.PAD0=236,b.PAD1=17,b.createData=function(a,c,d){for(var e=j.getRSBlocks(a,c),g=new k,h=0;h<d.length;h++){var i=d[h];g.put(i.mode,4),g.put(i.getLength(),f.getLengthInBits(i.mode,a)),i.write(g)}for(var l=0,h=0;h<e.length;h++)l+=e[h].dataCount;if(g.getLengthInBits()>8*l)throw new Error("code length overflow. ("+g.getLengthInBits()+">"+8*l+")");for(g.getLengthInBits()+4<=8*l&&g.put(0,4);0!=g.getLengthInBits()%8;)g.putBit(!1);for(;;){if(g.getLengthInBits()>=8*l)break;if(g.put(b.PAD0,8),g.getLengthInBits()>=8*l)break;g.put(b.PAD1,8)}return b.createBytes(g,e)},b.createBytes=function(a,b){for(var c=0,d=0,e=0,g=new Array(b.length),h=new Array(b.length),j=0;j<b.length;j++){var k=b[j].dataCount,l=b[j].totalCount-k;d=Math.max(d,k),e=Math.max(e,l),g[j]=new Array(k);for(var m=0;m<g[j].length;m++)g[j][m]=255&a.buffer[m+c];c+=k;var n=f.getErrorCorrectPolynomial(l),o=new i(g[j],n.getLength()-1),p=o.mod(n);h[j]=new Array(n.getLength()-1);for(var m=0;m<h[j].length;m++){var q=m+p.getLength()-h[j].length;h[j][m]=q>=0?p.get(q):0}}for(var r=0,m=0;m<b.length;m++)r+=b[m].totalCount;for(var s=new Array(r),t=0,m=0;d>m;m++)for(var j=0;j<b.length;j++)m<g[j].length&&(s[t++]=g[j][m]);for(var m=0;e>m;m++)for(var j=0;j<b.length;j++)m<h[j].length&&(s[t++]=h[j][m]);return s};for(var c={MODE_NUMBER:1,MODE_ALPHA_NUM:2,MODE_8BIT_BYTE:4,MODE_KANJI:8},d={L:1,M:0,Q:3,H:2},e={PATTERN000:0,PATTERN001:1,PATTERN010:2,PATTERN011:3,PATTERN100:4,PATTERN101:5,PATTERN110:6,PATTERN111:7},f={PATTERN_POSITION_TABLE:[[],[6,18],[6,22],[6,26],[6,30],[6,34],[6,22,38],[6,24,42],[6,26,46],[6,28,50],[6,30,54],[6,32,58],[6,34,62],[6,26,46,66],[6,26,48,70],[6,26,50,74],[6,30,54,78],[6,30,56,82],[6,30,58,86],[6,34,62,90],[6,28,50,72,94],[6,26,50,74,98],[6,30,54,78,102],[6,28,54,80,106],[6,32,58,84,110],[6,30,58,86,114],[6,34,62,90,118],[6,26,50,74,98,122],[6,30,54,78,102,126],[6,26,52,78,104,130],[6,30,56,82,108,134],[6,34,60,86,112,138],[6,30,58,86,114,142],[6,34,62,90,118,146],[6,30,54,78,102,126,150],[6,24,50,76,102,128,154],[6,28,54,80,106,132,158],[6,32,58,84,110,136,162],[6,26,54,82,110,138,166],[6,30,58,86,114,142,170]],G15:1335,G18:7973,G15_MASK:21522,getBCHTypeInfo:function(a){for(var b=a<<10;f.getBCHDigit(b)-f.getBCHDigit(f.G15)>=0;)b^=f.G15<<f.getBCHDigit(b)-f.getBCHDigit(f.G15);return(a<<10|b)^f.G15_MASK},getBCHTypeNumber:function(a){for(var b=a<<12;f.getBCHDigit(b)-f.getBCHDigit(f.G18)>=0;)b^=f.G18<<f.getBCHDigit(b)-f.getBCHDigit(f.G18);return a<<12|b},getBCHDigit:function(a){for(var b=0;0!=a;)b++,a>>>=1;return b},getPatternPosition:function(a){return f.PATTERN_POSITION_TABLE[a-1]},getMask:function(a,b,c){switch(a){case e.PATTERN000:return 0==(b+c)%2;case e.PATTERN001:return 0==b%2;case e.PATTERN010:return 0==c%3;case e.PATTERN011:return 0==(b+c)%3;case e.PATTERN100:return 0==(Math.floor(b/2)+Math.floor(c/3))%2;case e.PATTERN101:return 0==b*c%2+b*c%3;case e.PATTERN110:return 0==(b*c%2+b*c%3)%2;case e.PATTERN111:return 0==(b*c%3+(b+c)%2)%2;default:throw new Error("bad maskPattern:"+a)}},getErrorCorrectPolynomial:function(a){for(var b=new i([1],0),c=0;a>c;c++)b=b.multiply(new i([1,g.gexp(c)],0));return b},getLengthInBits:function(a,b){if(b>=1&&10>b)switch(a){case c.MODE_NUMBER:return 10;case c.MODE_ALPHA_NUM:return 9;case c.MODE_8BIT_BYTE:return 8;case c.MODE_KANJI:return 8;default:throw new Error("mode:"+a)}else if(27>b)switch(a){case c.MODE_NUMBER:return 12;case c.MODE_ALPHA_NUM:return 11;case c.MODE_8BIT_BYTE:return 16;case c.MODE_KANJI:return 10;default:throw new Error("mode:"+a)}else{if(!(41>b))throw new Error("type:"+b);switch(a){case c.MODE_NUMBER:return 14;case c.MODE_ALPHA_NUM:return 13;case c.MODE_8BIT_BYTE:return 16;case c.MODE_KANJI:return 12;default:throw new Error("mode:"+a)}}},getLostPoint:function(a){for(var b=a.getModuleCount(),c=0,d=0;b>d;d++)for(var e=0;b>e;e++){for(var f=0,g=a.isDark(d,e),h=-1;1>=h;h++)if(!(0>d+h||d+h>=b))for(var i=-1;1>=i;i++)0>e+i||e+i>=b||(0!=h||0!=i)&&g==a.isDark(d+h,e+i)&&f++;f>5&&(c+=3+f-5)}for(var d=0;b-1>d;d++)for(var e=0;b-1>e;e++){var j=0;a.isDark(d,e)&&j++,a.isDark(d+1,e)&&j++,a.isDark(d,e+1)&&j++,a.isDark(d+1,e+1)&&j++,(0==j||4==j)&&(c+=3)}for(var d=0;b>d;d++)for(var e=0;b-6>e;e++)a.isDark(d,e)&&!a.isDark(d,e+1)&&a.isDark(d,e+2)&&a.isDark(d,e+3)&&a.isDark(d,e+4)&&!a.isDark(d,e+5)&&a.isDark(d,e+6)&&(c+=40);for(var e=0;b>e;e++)for(var d=0;b-6>d;d++)a.isDark(d,e)&&!a.isDark(d+1,e)&&a.isDark(d+2,e)&&a.isDark(d+3,e)&&a.isDark(d+4,e)&&!a.isDark(d+5,e)&&a.isDark(d+6,e)&&(c+=40);for(var k=0,e=0;b>e;e++)for(var d=0;b>d;d++)a.isDark(d,e)&&k++;var l=Math.abs(100*k/b/b-50)/5;return c+=10*l}},g={glog:function(a){if(1>a)throw new Error("glog("+a+")");return g.LOG_TABLE[a]},gexp:function(a){for(;0>a;)a+=255;for(;a>=256;)a-=255;return g.EXP_TABLE[a]},EXP_TABLE:new Array(256),LOG_TABLE:new Array(256)},h=0;8>h;h++)g.EXP_TABLE[h]=1<<h;for(var h=8;256>h;h++)g.EXP_TABLE[h]=g.EXP_TABLE[h-4]^g.EXP_TABLE[h-5]^g.EXP_TABLE[h-6]^g.EXP_TABLE[h-8];for(var h=0;255>h;h++)g.LOG_TABLE[g.EXP_TABLE[h]]=h;i.prototype={get:function(a){return this.num[a]},getLength:function(){return this.num.length},multiply:function(a){for(var b=new Array(this.getLength()+a.getLength()-1),c=0;c<this.getLength();c++)for(var d=0;d<a.getLength();d++)b[c+d]^=g.gexp(g.glog(this.get(c))+g.glog(a.get(d)));return new i(b,0)},mod:function(a){if(this.getLength()-a.getLength()<0)return this;for(var b=g.glog(this.get(0))-g.glog(a.get(0)),c=new Array(this.getLength()),d=0;d<this.getLength();d++)c[d]=this.get(d);for(var d=0;d<a.getLength();d++)c[d]^=g.gexp(g.glog(a.get(d))+b);return new i(c,0).mod(a)}},j.RS_BLOCK_TABLE=[[1,26,19],[1,26,16],[1,26,13],[1,26,9],[1,44,34],[1,44,28],[1,44,22],[1,44,16],[1,70,55],[1,70,44],[2,35,17],[2,35,13],[1,100,80],[2,50,32],[2,50,24],[4,25,9],[1,134,108],[2,67,43],[2,33,15,2,34,16],[2,33,11,2,34,12],[2,86,68],[4,43,27],[4,43,19],[4,43,15],[2,98,78],[4,49,31],[2,32,14,4,33,15],[4,39,13,1,40,14],[2,121,97],[2,60,38,2,61,39],[4,40,18,2,41,19],[4,40,14,2,41,15],[2,146,116],[3,58,36,2,59,37],[4,36,16,4,37,17],[4,36,12,4,37,13],[2,86,68,2,87,69],[4,69,43,1,70,44],[6,43,19,2,44,20],[6,43,15,2,44,16],[4,101,81],[1,80,50,4,81,51],[4,50,22,4,51,23],[3,36,12,8,37,13],[2,116,92,2,117,93],[6,58,36,2,59,37],[4,46,20,6,47,21],[7,42,14,4,43,15],[4,133,107],[8,59,37,1,60,38],[8,44,20,4,45,21],[12,33,11,4,34,12],[3,145,115,1,146,116],[4,64,40,5,65,41],[11,36,16,5,37,17],[11,36,12,5,37,13],[5,109,87,1,110,88],[5,65,41,5,66,42],[5,54,24,7,55,25],[11,36,12],[5,122,98,1,123,99],[7,73,45,3,74,46],[15,43,19,2,44,20],[3,45,15,13,46,16],[1,135,107,5,136,108],[10,74,46,1,75,47],[1,50,22,15,51,23],[2,42,14,17,43,15],[5,150,120,1,151,121],[9,69,43,4,70,44],[17,50,22,1,51,23],[2,42,14,19,43,15],[3,141,113,4,142,114],[3,70,44,11,71,45],[17,47,21,4,48,22],[9,39,13,16,40,14],[3,135,107,5,136,108],[3,67,41,13,68,42],[15,54,24,5,55,25],[15,43,15,10,44,16],[4,144,116,4,145,117],[17,68,42],[17,50,22,6,51,23],[19,46,16,6,47,17],[2,139,111,7,140,112],[17,74,46],[7,54,24,16,55,25],[34,37,13],[4,151,121,5,152,122],[4,75,47,14,76,48],[11,54,24,14,55,25],[16,45,15,14,46,16],[6,147,117,4,148,118],[6,73,45,14,74,46],[11,54,24,16,55,25],[30,46,16,2,47,17],[8,132,106,4,133,107],[8,75,47,13,76,48],[7,54,24,22,55,25],[22,45,15,13,46,16],[10,142,114,2,143,115],[19,74,46,4,75,47],[28,50,22,6,51,23],[33,46,16,4,47,17],[8,152,122,4,153,123],[22,73,45,3,74,46],[8,53,23,26,54,24],[12,45,15,28,46,16],[3,147,117,10,148,118],[3,73,45,23,74,46],[4,54,24,31,55,25],[11,45,15,31,46,16],[7,146,116,7,147,117],[21,73,45,7,74,46],[1,53,23,37,54,24],[19,45,15,26,46,16],[5,145,115,10,146,116],[19,75,47,10,76,48],[15,54,24,25,55,25],[23,45,15,25,46,16],[13,145,115,3,146,116],[2,74,46,29,75,47],[42,54,24,1,55,25],[23,45,15,28,46,16],[17,145,115],[10,74,46,23,75,47],[10,54,24,35,55,25],[19,45,15,35,46,16],[17,145,115,1,146,116],[14,74,46,21,75,47],[29,54,24,19,55,25],[11,45,15,46,46,16],[13,145,115,6,146,116],[14,74,46,23,75,47],[44,54,24,7,55,25],[59,46,16,1,47,17],[12,151,121,7,152,122],[12,75,47,26,76,48],[39,54,24,14,55,25],[22,45,15,41,46,16],[6,151,121,14,152,122],[6,75,47,34,76,48],[46,54,24,10,55,25],[2,45,15,64,46,16],[17,152,122,4,153,123],[29,74,46,14,75,47],[49,54,24,10,55,25],[24,45,15,46,46,16],[4,152,122,18,153,123],[13,74,46,32,75,47],[48,54,24,14,55,25],[42,45,15,32,46,16],[20,147,117,4,148,118],[40,75,47,7,76,48],[43,54,24,22,55,25],[10,45,15,67,46,16],[19,148,118,6,149,119],[18,75,47,31,76,48],[34,54,24,34,55,25],[20,45,15,61,46,16]],j.getRSBlocks=function(a,b){var c=j.getRsBlockTable(a,b);if(void 0==c)throw new Error("bad rs block @ typeNumber:"+a+"/errorCorrectLevel:"+b);for(var d=c.length/3,e=[],f=0;d>f;f++)for(var g=c[3*f+0],h=c[3*f+1],i=c[3*f+2],k=0;g>k;k++)e.push(new j(h,i));return e},j.getRsBlockTable=function(a,b){switch(b){case d.L:return j.RS_BLOCK_TABLE[4*(a-1)+0];case d.M:return j.RS_BLOCK_TABLE[4*(a-1)+1];case d.Q:return j.RS_BLOCK_TABLE[4*(a-1)+2];case d.H:return j.RS_BLOCK_TABLE[4*(a-1)+3];default:return void 0}},k.prototype={get:function(a){var b=Math.floor(a/8);return 1==(1&this.buffer[b]>>>7-a%8)},put:function(a,b){for(var c=0;b>c;c++)this.putBit(1==(1&a>>>b-c-1))},getLengthInBits:function(){return this.length},putBit:function(a){var b=Math.floor(this.length/8);this.buffer.length<=b&&this.buffer.push(0),a&&(this.buffer[b]|=128>>>this.length%8),this.length++}};var l=[[17,14,11,7],[32,26,20,14],[53,42,32,24],[78,62,46,34],[106,84,60,44],[134,106,74,58],[154,122,86,64],[192,152,108,84],[230,180,130,98],[271,213,151,119],[321,251,177,137],[367,287,203,155],[425,331,241,177],[458,362,258,194],[520,412,292,220],[586,450,322,250],[644,504,364,280],[718,560,394,310],[792,624,442,338],[858,666,482,382],[929,711,509,403],[1003,779,565,439],[1091,857,611,461],[1171,911,661,511],[1273,997,715,535],[1367,1059,751,593],[1465,1125,805,625],[1528,1190,868,658],[1628,1264,908,698],[1732,1370,982,742],[1840,1452,1030,790],[1952,1538,1112,842],[2068,1628,1168,898],[2188,1722,1228,958],[2303,1809,1283,983],[2431,1911,1351,1051],[2563,1989,1423,1093],[2699,2099,1499,1139],[2809,2213,1579,1219],[2953,2331,1663,1273]],o=function(){var a=function(a,b){this._el=a,this._htOption=b};return a.prototype.draw=function(a){function g(a,b){var c=document.createElementNS("http://www.w3.org/2000/svg",a);for(var d in b)b.hasOwnProperty(d)&&c.setAttribute(d,b[d]);return c}var b=this._htOption,c=this._el,d=a.getModuleCount();Math.floor(b.width/d),Math.floor(b.height/d),this.clear();var h=g("svg",{viewBox:"0 0 "+String(d)+" "+String(d),width:"100%",height:"100%",fill:b.colorLight});h.setAttributeNS("http://www.w3.org/2000/xmlns/","xmlns:xlink","http://www.w3.org/1999/xlink"),c.appendChild(h),h.appendChild(g("rect",{fill:b.colorDark,width:"1",height:"1",id:"template"}));for(var i=0;d>i;i++)for(var j=0;d>j;j++)if(a.isDark(i,j)){var k=g("use",{x:String(i),y:String(j)});k.setAttributeNS("http://www.w3.org/1999/xlink","href","#template"),h.appendChild(k)}},a.prototype.clear=function(){for(;this._el.hasChildNodes();)this._el.removeChild(this._el.lastChild)},a}(),p="svg"===document.documentElement.tagName.toLowerCase(),q=p?o:m()?function(){function a(){this._elImage.src=this._elCanvas.toDataURL("image/png"),this._elImage.style.display="block",this._elCanvas.style.display="none"}function d(a,b){var c=this;if(c._fFail=b,c._fSuccess=a,null===c._bSupportDataURI){var d=document.createElement("img"),e=function(){c._bSupportDataURI=!1,c._fFail&&_fFail.call(c)},f=function(){c._bSupportDataURI=!0,c._fSuccess&&c._fSuccess.call(c)};return d.onabort=e,d.onerror=e,d.onload=f,d.src="data:image/gif;base64,iVBORw0KGgoAAAANSUhEUgAAAAUAAAAFCAYAAACNbyblAAAAHElEQVQI12P4//8/w38GIAXDIBKE0DHxgljNBAAO9TXL0Y4OHwAAAABJRU5ErkJggg==",void 0}c._bSupportDataURI===!0&&c._fSuccess?c._fSuccess.call(c):c._bSupportDataURI===!1&&c._fFail&&c._fFail.call(c)}if(this._android&&this._android<=2.1){var b=1/window.devicePixelRatio,c=CanvasRenderingContext2D.prototype.drawImage;CanvasRenderingContext2D.prototype.drawImage=function(a,d,e,f,g,h,i,j){if("nodeName"in a&&/img/i.test(a.nodeName))for(var l=arguments.length-1;l>=1;l--)arguments[l]=arguments[l]*b;else"undefined"==typeof j&&(arguments[1]*=b,arguments[2]*=b,arguments[3]*=b,arguments[4]*=b);c.apply(this,arguments)}}var e=function(a,b){this._bIsPainted=!1,this._android=n(),this._htOption=b,this._elCanvas=document.createElement("canvas"),this._elCanvas.width=b.width,this._elCanvas.height=b.height,a.appendChild(this._elCanvas),this._el=a,this._oContext=this._elCanvas.getContext("2d"),this._bIsPainted=!1,this._elImage=document.createElement("img"),this._elImage.style.display="none",this._el.appendChild(this._elImage),this._bSupportDataURI=null};return e.prototype.draw=function(a){var b=this._elImage,c=this._oContext,d=this._htOption,e=a.getModuleCount(),f=d.width/e,g=d.height/e,h=Math.round(f),i=Math.round(g);b.style.display="none",this.clear();for(var j=0;e>j;j++)for(var k=0;e>k;k++){var l=a.isDark(j,k),m=k*f,n=j*g;c.strokeStyle=l?d.colorDark:d.colorLight,c.lineWidth=1,c.fillStyle=l?d.colorDark:d.colorLight,c.fillRect(m,n,f,g),c.strokeRect(Math.floor(m)+.5,Math.floor(n)+.5,h,i),c.strokeRect(Math.ceil(m)-.5,Math.ceil(n)-.5,h,i)}this._bIsPainted=!0},e.prototype.makeImage=function(){this._bIsPainted&&d.call(this,a)},e.prototype.isPainted=function(){return this._bIsPainted},e.prototype.clear=function(){this._oContext.clearRect(0,0,this._elCanvas.width,this._elCanvas.height),this._bIsPainted=!1},e.prototype.round=function(a){return a?Math.floor(1e3*a)/1e3:a},e}():function(){var a=function(a,b){this._el=a,this._htOption=b};return a.prototype.draw=function(a){for(var b=this._htOption,c=this._el,d=a.getModuleCount(),e=Math.floor(b.width/d),f=Math.floor(b.height/d),g=['<table style="border:0;border-collapse:collapse;">'],h=0;d>h;h++){g.push("<tr>");for(var i=0;d>i;i++)g.push('<td style="border:0;border-collapse:collapse;padding:0;margin:0;width:'+e+"px;height:"+f+"px;background-color:"+(a.isDark(h,i)?b.colorDark:b.colorLight)+';"></td>');g.push("</tr>")}g.push("</table>"),c.innerHTML=g.join("");var j=c.childNodes[0],k=(b.width-j.offsetWidth)/2,l=(b.height-j.offsetHeight)/2;k>0&&l>0&&(j.style.margin=l+"px "+k+"px")},a.prototype.clear=function(){this._el.innerHTML=""},a}();QRCode=function(a,b){if(this._htOption={width:256,height:256,typeNumber:4,colorDark:"#000000",colorLight:"#ffffff",correctLevel:d.H},"string"==typeof b&&(b={text:b}),b)for(var c in b)this._htOption[c]=b[c];"string"==typeof a&&(a=document.getElementById(a)),this._android=n(),this._el=a,this._oQRCode=null,this._oDrawing=new q(this._el,this._htOption),this._htOption.text&&this.makeCode(this._htOption.text)},QRCode.prototype.makeCode=function(a){this._oQRCode=new b(r(a,this._htOption.correctLevel),this._htOption.correctLevel),this._oQRCode.addData(a),this._oQRCode.make(),this._el.title=a,this._oDrawing.draw(this._oQRCode),this.makeImage()},QRCode.prototype.makeImage=function(){"function"==typeof this._oDrawing.makeImage&&(!this._android||this._android>=3)&&this._oDrawing.makeImage()},QRCode.prototype.clear=function(){this._oDrawing.clear()},QRCode.CorrectLevel=d}();]]>
        </script>
<style type="text/css">
body {
    background-color: #FFFFFF;
    font-family: 'Tahoma', "Times New Roman", Times, serif;
    font-size: 12px;
    color: #666666;
}
h1, h2 {
    padding-bottom: 3px;
    padding-top: 3px;
    margin-bottom: 5px;
    text-transform: uppercase;
    font-family: Arial, Helvetica, sans-serif;
}
h1 {
    font-size: 1.4em;
    text-transform:none;
}
h2 {
    font-size: 1em;
    color: brown;
}
h3 {
    font-size: 1em;
    color: #333333;
    text-align: justify;
    margin: 0;
    padding: 0;
}
h4 {
    font-size: 1.1em;
    font-style: bold;
    font-family: Arial, Helvetica, sans-serif;
    color: #000000;
    margin: 0;
    padding: 0;
}
hr {
    height:1px;
    color: #000000;
    background-color: #000000;
    border-bottom: 0px solid #000000;
}
p, ul, ol {
    margin-top: 1.5em;
}
ul, ol {
    margin-left: 3em;
}
blockquote {
    margin-left: 3em;
    margin-right: 3em;
    font-style: italic;
}
a {
    text-decoration: none;
    color: #70A300;
}
a:hover {
    border: none;
    color: #70A300;
}
#despatchTable {
    border: 1px solid black;
    border-radius: 8px;
    border-collapse: separate;
    border-spacing: 0px;
    padding: 3px;
    float:right;
}
#ettnTable {
    border: 0px solid black;
    border-radius: 8px;
    border-collapse: separate;
    border-spacing: 0px;
    padding: 3px;
}
#supplierPartyTable {
    border: 0px;
    width: 100%;
    padding: 10px;
}
#customerPartyTable {
    border: 1px solid black;
    width: 100%;
    border-radius: 8px;
    border-collapse: separate;
    border-spacing: 0px;
    padding: 10px;
}
#customerIDTable {
    border-width: 2px;
    border-spacing:;
    border-style: inset;
    border-color: gray;
    border-collapse: collapse;
    background-color:
}
#customerIDTableTd {
    border-width: 2px;
    border-spacing:;
    border-style: inset;
    border-color: gray;
    border-collapse: collapse;
    background-color:
}
#lineTable {
    border-width:1px;
    border-style: solid;
    border-color: white;
    border-collapse: collapse;
}
#lineTableTd {
    border-width: 1px;
    padding: 3px;
    border-style: solid;
    border-color: white;
}
#lineTableTdHead {
    border-width: 1px;
    padding: 3px;
    border-style: solid;
    border-color: white;
    background-color: #8BBFD5;    
}
#lineTableTr {
    border-width: 1px;
    padding: 0px;
    border-style: solid;
    border-color: white;
    -moz-border-radius:;
}
#lineTableBudgetTd {
    border-width: 1px;
    border-spacing:0px;
    padding: 3px;
    border-style: solid;
    border-color: white;
    background-color: white;
    -moz-border-radius:;
}
#notesTable {
    border-width: 2px;
    border-spacing:;
    border-style: inset;
    border-color: black;
    border-collapse: collapse;
    background-color:
}
#notesTableTd {
    border-width: 0px;
    border-spacing:;
    border-style: inset;
    border-color: black;
    border-collapse: collapse;
    background-color:

}
table {
    border-spacing:0px;
}
#budgetContainerTable {
    border-width: 0px;
    border-spacing: 0px;
    border-style: inset;
    border-color: black;
    border-collapse: collapse;
    margin-top:5px;
}
td {
    border-color:gray;
}
#tdBordered {
    border-radius: 8px;
    border: 1px solid black;
}</style>
<title>e-Fatura</title>
</head>
<body style="margin:0.3in">
<xsl:for-each select="$XML">
<table border="0" cellspacing="0px" cellpadding="0px" id="tballbody"><tbody><tr valign="top"><td>
<table border="0" cellspacing="0px" width="747px" cellpadding="0px"><tbody>
<tr valign="top">
	<td width="336px" align="left" valign="middle"><xsl:apply-templates select="//n1:Invoice" mode="LogoVeFirma"/></td>
	<td width="161px" align="center" valign="middle"><xsl:apply-templates select="//n1:Invoice" mode="Logo"/></td>
	<td width="250px" align="right" valign="middle" height="160px"><xsl:apply-templates select="//n1:Invoice" mode="QrCode"/></td>
</tr>
<tr valign="top">
	<td align="left"><xsl:apply-templates select="n1:Invoice/cac:AccountingCustomerParty"/></td>
	<td align="center" valign="middle" style="margin-left:20px;margin-right:20px;"><xsl:apply-templates select="//n1:Invoice" mode="FirmaKase"/></td>
	<td rowspan="2" align="right" valign="bottom"><xsl:apply-templates select="//n1:Invoice" mode="FaturaInfo"/></td>
</tr>
<tr align="left" valign="bottom">
	<td colspan="2"><xsl:apply-templates select="n1:Invoice/cbc:UUID"/></td>
</tr>
<xsl:apply-templates select="n1:Invoice" mode="MusteriDetay"/>
</tbody></table>

<div id="lineTableAligner" style="height:5px"><span><xsl:text></xsl:text></span></div>
<table style="width:747px;border:1px solid black; border-radius:8px;border-spacing:1px;margin-left: 1px;"><tbody>
<tr><td style="vertical-align:top">
<table id="lineTable" width="100%"><tbody>
<tr id="lineTableTr">
	<xsl:if test="$sablonturu='N'">
		<td id="lineTableTdHead" style="width:24%;border-top-left-radius:8px;" align="center"><span style="font-weight:bold;"><xsl:text>Cinsi</xsl:text></span></td>
		<xsl:if test="$ozelmusteri='1'">
			<td id="lineTableTdHead" style="width:14%" align="center"><span style="font-weight:bold;"><xsl:text>Kodu</xsl:text></span></td>
		</xsl:if>
		<xsl:if test="$satiraciklama='1'">
			<td id="lineTableTdHead" style="width:10%" align="center"><span style="font-weight:bold;"><xsl:text>Açıklama</xsl:text></span></td>
		</xsl:if>
		<td id="lineTableTdHead" style="width:10%" align="center"><span style="font-weight:bold;"><xsl:text>Miktar</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:07%" align="center"><span style="font-weight:bold;"><xsl:text>Birim</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:10%" align="center"><span style="font-weight:bold;"><xsl:text>Fiyat</xsl:text></span></td>
		<xsl:if test="//n1:Invoice/cbc:ProfileID!='IHRACAT'">
			<td id="lineTableTdHead" style="width:07%" align="center"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
		</xsl:if>
		<xsl:if test="//n1:Invoice/cac:InvoiceLine/cac:AllowanceCharge">
			<td id="lineTableTdHead" style="width:8%" align="center"><span style="font-weight:bold;"><xsl:text>İskonto Tutarı</xsl:text></span></td>
		</xsl:if>
		<xsl:if test="//n1:Invoice/cbc:ProfileID='IHRACAT'">
			<td id="lineTableTdHead" align="center"><span style="font-weight:bold;"><xsl:text>Teslim Şartı</xsl:text></span></td>
			<td id="lineTableTdHead" align="center"><span style="font-weight:bold;"><xsl:text>Paket Cinsi</xsl:text></span></td>
			<td id="lineTableTdHead" align="center"><span style="font-weight:bold;"><xsl:text>Paket No</xsl:text></span></td>
			<td id="lineTableTdHead" align="center"><span style="font-weight:bold;"><xsl:text>Paket Adet</xsl:text></span></td>
			<td id="lineTableTdHead" align="center"><span style="font-weight:bold;"><xsl:text>Taşıma Şekli</xsl:text></span></td>
			<td id="lineTableTdHead" align="center"><span style="font-weight:bold;"><xsl:text>GTIP</xsl:text></span></td>
		</xsl:if>
		<td id="lineTableTdHead" style="width:10%;border-top-right-radius:8px;" align="center"><span style="font-weight:bold;"><xsl:text>Mal Tutarı</xsl:text></span></td>
	</xsl:if>

	<xsl:if test="$sablonturu='H'">
		<xsl:if test="$markagoster='1'">
			<td id="lineTableTdHead" style="width:08%;border-top-left-radius:8px;" align="center"><span style="font-weight:bold;"><xsl:text>Marka</xsl:text></span></td>
		</xsl:if>
		<xsl:if test="$ozelmusteri='1'">
			<td id="lineTableTdHead" style="width:10%" align="center"><span style="font-weight:bold;"><xsl:text>Kodu</xsl:text></span></td>
		</xsl:if>
		<td id="lineTableTdHead" style="width:17%" align="center"><span style="font-weight:bold;"><xsl:text>Cinsi</xsl:text></span></td>
		<xsl:if test="$satiraciklama='1'">
			<td id="lineTableTdHead" style="width:6%" align="center"><span style="font-weight:bold;"><xsl:text>Açıklama</xsl:text></span></td>
		</xsl:if>
		<td id="lineTableTdHead" style="width:14%" align="center"><span style="font-weight:bold;"><xsl:text>Künye</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:06%" align="center"><span style="font-weight:bold;"><xsl:if test="$projeturu='B'"><xsl:text>Ks/Ad</xsl:text></xsl:if><xsl:if test="$projeturu='H'"><xsl:text>Adet</xsl:text></xsl:if></span></td>
		<td id="lineTableTdHead" style="width:06%" align="center"><span style="font-weight:bold;"><xsl:if test="$projeturu='B'"><xsl:text>Bğ/Kg</xsl:text></xsl:if><xsl:if test="$projeturu='H'"><xsl:text>Daralı</xsl:text></xsl:if></span></td>
		<xsl:if test="$daragoster='1'">
			<td id="lineTableTdHead" style="width:06%" align="center"><span style="font-weight:bold;"><xsl:text>Dara</xsl:text></span></td>
			<td id="lineTableTdHead" style="width:08%" align="center"><span style="font-weight:bold;"><xsl:text>Safi</xsl:text></span></td>
		</xsl:if>
		<td id="lineTableTdHead" style="width:06%" align="center"><span style="font-weight:bold;"><xsl:text>Fiyat</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:05%" align="center"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:08%;border-top-right-radius:8px;" align="center"><span style="font-weight:bold;"><xsl:text>Tutar</xsl:text></span></td>
	</xsl:if>

	<xsl:if test="$sablonturu='K'">
		<td id="lineTableTdHead" style="width:36%;border-top-left-radius:8px;" align="center"><span style="font-weight:bold;"><xsl:text>Cinsi</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:16%" align="center"><span style="font-weight:bold;"><xsl:text>Künye</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:10%" align="center"><span style="font-weight:bold;"><xsl:if test="$projeturu='B'"><xsl:text>Ks/Ad</xsl:text></xsl:if><xsl:if test="$projeturu='H'"><xsl:text>Adet</xsl:text></xsl:if></span></td>
		<td id="lineTableTdHead" style="width:10%" align="center"><span style="font-weight:bold;"><xsl:if test="$projeturu='B'"><xsl:text>Bğ/Kg</xsl:text></xsl:if><xsl:if test="$projeturu='H'"><xsl:text>Kilo</xsl:text></xsl:if></span></td>
		<td id="lineTableTdHead" style="width:10%" align="center"><span style="font-weight:bold;"><xsl:text>Fiyat</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:06%" align="center"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
		<td id="lineTableTdHead" style="width:12%;border-top-right-radius:8px;" align="center"><span style="font-weight:bold;"><xsl:text>Tutar</xsl:text></span></td>
	</xsl:if>
</tr>
<xsl:for-each select="//n1:Invoice/cac:InvoiceLine"><xsl:apply-templates select="."/></xsl:for-each>
</tbody></table>
</td></tr></tbody></table>

<div id="lineTableAligner" style="height:1px"><span><xsl:text></xsl:text></span></div>
<table style="width:747px;border-spacing:2px"><tbody>
	<xsl:if test="$sablonturu='N'">
		<tr>
			<td id="tdBordered" align="left" valign="bottom" style="width:60%;padding:2px"><xsl:apply-templates select="//n1:Invoice" mode="FooterLeft"/></td>
			<td id="tdBordered" align="right" style="width:40%;padding:2px"><xsl:apply-templates select="//n1:Invoice" mode="FooterRight"/></td>
		</tr>
	</xsl:if>

	<xsl:if test="$sablonturu='H'">
		<tr>
			<td id="tdBordered" align="left" valign="top" style="width:30%;padding:2px"><xsl:apply-templates select="//n1:Invoice" mode="FooterLeft"/></td>
			<td id="tdBordered" align="center" valign="top" style="width:30%;padding:2px"><xsl:apply-templates select="//n1:Invoice" mode="FooterCenter"/></td>
			<td id="tdBordered" align="right" valign="top" style="width:40%;padding:2px"><xsl:apply-templates select="//n1:Invoice" mode="FooterRight"/></td>
		</tr>
		<tr><td id="tdBordered" align="right" colspan="3" style="padding:5px"><xsl:apply-templates select="//n1:Invoice" mode="MoneyToText"/></td></tr>
	</xsl:if>

	<xsl:if test="$sablonturu='K'">
		<tr>
			<td id="tdBordered" align="left" colspan="2" valign="top"><xsl:apply-templates select="//n1:Invoice" mode="FooterToplam"/></td>
		</tr>
		<tr>
			<td id="tdBordered" align="center" valign="top" style="width:60%;padding:2px"><xsl:apply-templates select="//n1:Invoice" mode="FooterKomisyonMasraf"/></td>
			<td id="tdBordered" align="right" valign="top" style="width:40%;padding:2px"><xsl:apply-templates select="//n1:Invoice" mode="FooterRight"/></td>
		</tr>
		<tr>
			<td id="tdBordered" align="right" colspan="2" style="padding:5px"><xsl:apply-templates select="//n1:Invoice" mode="MoneyToText"/></td>
		</tr>
	</xsl:if>

	<xsl:if test="$sablonturu!='K'">
		<xsl:apply-templates select="//n1:Invoice" mode="FooterAciklama"/>
		<xsl:apply-templates select="//n1:Invoice" mode="BankaHesap"/>
		<xsl:apply-templates select="//n1:Invoice" mode="SameIrsaliye"/>
	</xsl:if>
</tbody></table>
</td></tr>

<xsl:if test="$ozelmusteri!='1'"><tr valign="bottom"><td height="100%"><span id="sprehin"></span></td></tr></xsl:if>
</tbody></table>

</xsl:for-each>
</body>
</html>
</xsl:template>

<xsl:template match="*" mode="Tarih">
	<xsl:value-of select="substring(.,9,2)"/>-<xsl:value-of select="substring(.,6,2)"/>-<xsl:value-of select="substring(.,1,4)"/>
</xsl:template>

<xsl:template match="cbc:IssueDate">
	<xsl:apply-templates select="." mode="Tarih"/>
</xsl:template>

<xsl:template match="cbc:IssueTime">
	<xsl:value-of select="substring(.,1,8)"/>
</xsl:template>

<xsl:template match="*" mode="MoneyToText">
	<xsl:for-each select="cac:AdditionalDocumentReference">
	<xsl:if test="cbc:DocumentType='MONEYTEXT'">
		<span style="font-weight:bold;font-size:15px"><xsl:value-of select="cbc:ID"/></span>
	</xsl:if>
	</xsl:for-each>
</xsl:template>

<xsl:template match="*" mode="CurrencyID">
	<xsl:apply-templates select="//n1:Invoice/cbc:DocumentCurrencyCode" mode="docCurrencyID"/>
</xsl:template>

<xsl:template match="//n1:Invoice/cbc:DocumentCurrencyCode" mode="docCurrencyID">
	<xsl:if test="."><xsl:text> </xsl:text>
	<xsl:if test=".='TRY'"><xsl:text>TL</xsl:text></xsl:if>
	<xsl:if test=".!='TRY'"><xsl:value-of select="."/></xsl:if>
	</xsl:if>
	<xsl:text>&#160;</xsl:text>
</xsl:template>

<xsl:template match="*" mode="CurrencyIDTLYok">
	<xsl:if test="./@currencyID"><xsl:text> </xsl:text>
	<xsl:if test="./@currencyID != 'TRY'"><xsl:value-of select="./@currencyID"/></xsl:if>
	</xsl:if>
	<xsl:text>&#160;</xsl:text>
</xsl:template>

<!--*************************************** FOOTERKOMISYONMASRAF ****************************** -->
<xsl:template match="//n1:Invoice" mode="FooterKomisyonMasraf">
	<table id="budgetContainerTable" width="100%"><tbody>
		<tr id="budgetContainerTr">
			<xsl:apply-templates select="." mode="M_Navlun"/>
			<xsl:apply-templates select="." mode="M_NavlunTevkifat"/>
		</tr>
		<tr id="budgetContainerTr">
			<xsl:apply-templates select="." mode="M_Nakliye"/>
			<xsl:apply-templates select="." mode="M_Bagkur"/>
		</tr>
		<tr id="budgetContainerTr">
			<xsl:apply-templates select="." mode="M_Hamaliye"/>
			<xsl:apply-templates select="." mode="M_Stopaj"/>
		</tr>
		<tr id="budgetContainerTr">
			<xsl:apply-templates select="." mode="M_Diger"/>
			<xsl:apply-templates select="." mode="M_Rusum"/>
		</tr>
		<tr id="budgetContainerTr">
			<xsl:apply-templates select="." mode="M_Komisyon"/>
			<xsl:apply-templates select="." mode="M_Borsa"/>
		</tr>
	</tbody></table>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Navlun">
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Navlun</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAVLUN' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.##0,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAVLUN' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="left">&#160;</td>
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAVLUNKDV' and cbc:ChargeIndicator='false' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAVLUNKDV' and cbc:ChargeIndicator='false' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="left">&#160;</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_NavlunTevkifat">
	<td id="lineTableBudgetTd" align="left" width="50px"><span style="font-weight:bold;"><xsl:text>Tevkifat</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right" width="30px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAVLUNKDV' and cbc:ChargeIndicator='true' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right" width="50px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAVLUNKDV' and cbc:ChargeIndicator='true' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Nakliye">
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Nakliye</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAKLIYE' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.##0,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAKLIYE' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="left">&#160;</td>
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAKLIYEKDV' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSNAKLIYEKDV' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="left">&#160;</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Bagkur">
	<td id="lineTableBudgetTd" align="left" width="50px"><span style="font-weight:bold;"><xsl:text>Bağkur</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right" width="30px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSBAGKURTEVKIFAT' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right" width="50px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSBAGKURTEVKIFAT' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Hamaliye">
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Hamaliye</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSHAMMALIYE' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.##0,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSHAMMALIYE' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="left">&#160;</td>
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSHAMMALIYEKDV' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSHAMMALIYEKDV' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="left">&#160;</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Stopaj">
	<td id="lineTableBudgetTd" align="left" width="50px"><span style="font-weight:bold;"><xsl:text>Stopaj</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right" width="30px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSGVTEVKIFAT' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right" width="50px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSGVTEVKIFAT' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Diger">
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Diğer</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSDIGERMASRAFLAR' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.##0,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSDIGERMASRAFLAR' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="left">&#160;</td>
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSDIGERKDV' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSDIGERKDV' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="left">&#160;</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Rusum">
	<td id="lineTableBudgetTd" align="left" width="50px"><span style="font-weight:bold;"><xsl:text>Rüsum</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right" width="30px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSRUSUM' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right" width="50px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSRUSUM' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Komisyon">
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Komisyon</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSKOMISYON' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.##0,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSKOMISYON' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="left">&#160;</td>
	<td id="lineTableBudgetTd" align="left"><span style="font-weight:bold;"><xsl:text>Kdv</xsl:text></span></td>
	
	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSKOMISYONKDV' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="right">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSKOMISYONKDV' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>

	<td id="lineTableBudgetTd" align="left">&#160;</td>
</xsl:template>

<xsl:template match="//n1:Invoice" mode="M_Borsa">
	<td id="lineTableBudgetTd" align="left" width="50px"><span style="font-weight:bold;"><xsl:text>Borsa</xsl:text></span></td>

	<td id="lineTableBudgetTd" align="right" width="30px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSTICBORSASI' and cbc:Amount!='0' and cbc:MultiplierFactorNumeric!='0'"><xsl:text> %</xsl:text><xsl:value-of select="format-number(cbc:MultiplierFactorNumeric, '###.###,##', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
	
	<td id="lineTableBudgetTd" align="right" width="50px">
	<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:AllowanceChargeReason='HKSTICBORSASI' and cbc:Amount!='0'"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/></xsl:if>
	</xsl:for-each>
	</td>
</xsl:template>
<!--*************************************** FOOTERKOMISYONMASRAF ****************************** -->

<!--*************************************** FOOTERLEFT ******************************** -->
<xsl:template match="//n1:Invoice" mode="FooterLeft">
	<table id="budgetContainerTable" style="width:100%"><tbody>
	<xsl:if test="$sablonturu='N'">
		<xsl:if test="$ozelmusteri!='1' and $bakiye!=''">
			<tr id="budgetContainerTr"><td colspan="2" id="lineTableBudgetTd"><span style="font-weight:bold;"><xsl:text>&#160;Fatura Dahil Bakiye</xsl:text></span></td></tr>
			<tr id="budgetContainerTr">
				<td id="lineTableBudgetTd" width="130px" align="right" style="font-weight:bold;"><xsl:text>&#160;</xsl:text><xsl:value-of select="$bakiye"/></td>
				<td id="lineTableBudgetTd"><xsl:text>&#160;</xsl:text></td>
			</tr>
			<tr id="budgetContainerTr"><td colspan="2" id="lineTableBudgetTd"><xsl:text>&#160;</xsl:text></td></tr>
		</xsl:if>
		<tr id="budgetContainerTr"><td colspan="2" id="budgetContainerTr" align="right" valign="bottom"><xsl:apply-templates select="." mode="MoneyToText"/></td></tr>
	</xsl:if>

	<xsl:if test="$sablonturu='H'">
		<xsl:if test="$projeturu='B'">
		<tr id="budgetContainerTr">
			<td id="lineTableBudgetTd" width="100px"><span style="font-weight:bold;"><xsl:text>&#160;Kasa</xsl:text></span></td>
			<td id="lineTableBudgetTd" width="80px"><xsl:text>&#160;</xsl:text><xsl:value-of select="$kasa"/></td>
			<td id="lineTableBudgetTd" width="20px"><span><xsl:text>&#160;</xsl:text></span></td>

			<td id="lineTableBudgetTd" width="100px"><span style="font-weight:bold;"><xsl:text>&#160;Bağ</xsl:text></span></td>
			<td id="lineTableBudgetTd" width="80px"><xsl:text>&#160;</xsl:text><xsl:value-of select="$bag"/></td>
		</tr>
		</xsl:if>
		<tr id="budgetContainerTr">
			<td id="lineTableBudgetTd" width="100px"><span style="font-weight:bold;"><xsl:text>&#160;Adet</xsl:text></span></td>
			<td id="lineTableBudgetTd" width="80px"><xsl:text>&#160;</xsl:text><xsl:value-of select="$adet"/></td>
			<td id="lineTableBudgetTd" width="20px"><span><xsl:text>&#160;</xsl:text></span></td>

			<td id="lineTableBudgetTd" width="100px"><span style="font-weight:bold;"><xsl:text>&#160;Safi</xsl:text></span></td>
			<td id="lineTableBudgetTd" width="80px"><xsl:text>&#160;</xsl:text><xsl:value-of select="$kilo"/></td>
		</tr>
		<tr id="budgetContainerTr">
			<td id="lineTableBudgetTd" width="100px"><span style="font-weight:bold;"><xsl:text>&#160;Plaka</xsl:text></span></td>
			<td id="lineTableBudgetTd" width="80px" colspan="4"><xsl:text>&#160;</xsl:text><xsl:value-of select="$plakano"/></td>
		</tr>
		<xsl:if test="$ozelmusteri!='1'">
			<xsl:if test="$bakiye!=''">
			<tr id="budgetContainerTr"><td id="lineTableBudgetTd" width="180px" colspan="5"><span><xsl:text>&#160;</xsl:text></span></td></tr>
			<tr id="budgetContainerTr"><td id="lineTableBudgetTd" width="180px" colspan="5"><span style="font-weight:bold;"><xsl:text>&#160;Fatura Dahil Bakiye</xsl:text></span></td></tr>
			<tr id="budgetContainerTr"><td id="lineTableBudgetTd" width="180px" colspan="5" align="center" style="font-weight:bold;"><xsl:text>&#160;</xsl:text><xsl:value-of select="$bakiye"/></td></tr>
			</xsl:if>
		</xsl:if>
	</xsl:if>
	</tbody></table>
</xsl:template>
<!--*************************************** FOOTERLEFT ******************************** -->

<!--*************************************** FOOTERCENTER ****************************** -->
<xsl:template match="//n1:Invoice" mode="FooterCenter">
	<table id="budgetContainerTable"><tbody>
	<tr id="budgetContainerTr">
		<td id="lineTableBudgetTd" align="left" width="90px"><span style="font-weight:bold;"><xsl:text>Hamaliye&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" align="right" width="60px">
			<xsl:if test="$hamaliyetutari!=''"><xsl:value-of select="$hamaliyetutari"/>
			<xsl:apply-templates select="." mode="CurrencyID"/></xsl:if>
		</td>
		<td id="lineTableBudgetTd" align="left" width="30px"><span style="font-weight:bold;"><xsl:text>Kdv&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" align="right" width="45px"><xsl:if test="$hamaliyekdvorani!='' and $hamaliyetutari!=''"><xsl:text> %</xsl:text><xsl:value-of select="$hamaliyekdvorani"/><xsl:text>&#160;</xsl:text></xsl:if></td>
	</tr>
	<tr>
		<td id="lineTableBudgetTd" align="left" width="90px"><span style="font-weight:bold;"><xsl:text>Nakliye&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" align="right" width="60px">
			<xsl:if test="$nakliyetutari!=''"><xsl:value-of select="$nakliyetutari"/>
			<xsl:apply-templates select="." mode="CurrencyID"/></xsl:if>
		</td>
		<td id="lineTableBudgetTd" align="left" width="30px"><span style="font-weight:bold;"><xsl:text>Kdv&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" align="right" width="45px"><xsl:if test="$nakliyekdvorani!='' and $nakliyetutari!=''"><xsl:text> %</xsl:text><xsl:value-of select="$nakliyekdvorani"/><xsl:text>&#160;</xsl:text></xsl:if></td>
	</tr>
	<tr>
		<td id="lineTableBudgetTd" align="left" width="90px"><span style="font-weight:bold;"><xsl:text>İadesiz Sandık&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" align="right" width="60px">
			<xsl:if test="$isandiktutari!=''"><xsl:value-of select="$isandiktutari"/>
			<xsl:apply-templates select="." mode="CurrencyID"/></xsl:if>
		</td>
		<td id="lineTableBudgetTd" align="left" width="30px"><span style="font-weight:bold;"><xsl:text>Kdv&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" align="right" width="45px"><xsl:if test="$isandikkdvorani!='' and $isandiktutari!=''"><xsl:text> %</xsl:text><xsl:value-of select="$isandikkdvorani"/><xsl:text>&#160;</xsl:text></xsl:if></td>
	</tr>
	<tr>
		<td id="lineTableBudgetTd" align="left" width="90px"><span style="font-weight:bold;"><xsl:text>İadesiz Sandık&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" align="right" width="60px">
			<xsl:if test="$kdvsizisandiktutari!=''"><xsl:value-of select="$kdvsizisandiktutari"/>
			<xsl:apply-templates select="." mode="CurrencyID"/></xsl:if>
		</td>
		<td id="lineTableBudgetTd" align="left" width="30px"><xsl:text>&#160;</xsl:text></td>
		<td id="lineTableBudgetTd" align="right" width="45px"><xsl:text>&#160;</xsl:text></td>
	</tr>
	</tbody></table>
</xsl:template>
<!--*************************************** FOOTERCENTER ****************************** -->

<!--*************************************** FOOTERRIGHT ******************************* -->
<xsl:template match="//n1:Invoice" mode="FooterRight">
	<table id="budgetContainerTable"><tbody>
	<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5;border-top-left-radius:8px"><span style="font-weight:bold;"><xsl:text>Mal Toplamı&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" style="width:85px;" align="right">
		        <xsl:if test="cac:LegalMonetaryTotal/cbc:LineExtensionAmount!=''"><span>
			<xsl:value-of select="format-number(cac:LegalMonetaryTotal/cbc:LineExtensionAmount, '###.##0,00', 'european')"/>
			<xsl:apply-templates select="cac:LegalMonetaryTotal/cbc:LineExtensionAmount" mode="CurrencyID"/></span></xsl:if>
		</td>
	</tr>

	<xsl:if test="$sablonturu!='K'">
		<xsl:for-each select="cac:AllowanceCharge">
		<xsl:if test="cbc:ChargeIndicator = 'false'">	
		<tr id="budgetContainerTr" align="right">
			<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:value-of select="cbc:AllowanceChargeReason"/><xsl:text>&#160;</xsl:text></span></td>
			<td id="lineTableBudgetTd" style="width:85px; " align="right">
				<xsl:if test="cbc:Amount!=''"><span>
				<xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/>
				<xsl:apply-templates select="cbc:Amount" mode="CurrencyID"/></span></xsl:if>
			</td>
		</tr>
		</xsl:if>
		</xsl:for-each>

		<xsl:if test="cac:AllowanceCharge">
		<tr id="budgetContainerTr" align="right">
			<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:text>Matrah&#160;</xsl:text></span></td>
			<td id="lineTableBudgetTd" style="width:85px; " align="right">
				<xsl:if test="cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount!=''"><span>
				<xsl:value-of select="format-number(cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount, '###.##0,00', 'european')"/>
				<xsl:apply-templates select="cac:LegalMonetaryTotal/cbc:TaxExclusiveAmount" mode="CurrencyID"/></span></xsl:if>
			</td>
		</tr>
		</xsl:if>
	</xsl:if>

	<xsl:if test="$sablonturu='K'">
		<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:text>Masraf Toplamı&#160;</xsl:text></span></td>
			<td id="lineTableBudgetTd" style="width:85px; " align="right">
				<xsl:if test="cac:LegalMonetaryTotal/cbc:ChargeTotalAmount!=''"><span>
				<xsl:value-of select="format-number(cac:LegalMonetaryTotal/cbc:ChargeTotalAmount, '###.##0,00', 'european')"/>
				<xsl:apply-templates select="cac:LegalMonetaryTotal/cbc:ChargeTotalAmount" mode="CurrencyID"/></span></xsl:if>
			</td>
		</tr>
		<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:text>Net Toplam&#160;</xsl:text></span></td>
			<td id="lineTableBudgetTd" style="width:85px; " align="right">
				<xsl:if test="cac:LegalMonetaryTotal/cbc:ChargeTotalAmount!=''"><span>
				<xsl:value-of select="format-number(cac:LegalMonetaryTotal/cbc:LineExtensionAmount - cac:LegalMonetaryTotal/cbc:ChargeTotalAmount, '###.##0,00', 'european')"/>
				<xsl:apply-templates select="cac:LegalMonetaryTotal/cbc:ChargeTotalAmount" mode="CurrencyID"/></span></xsl:if>
			</td>
		</tr>
		<xsl:for-each select="cac:AllowanceCharge">
			<xsl:if test="cbc:AllowanceChargeReason='KDVSIZISANDIK' and cbc:Amount!='0'">
			<tr id="budgetContainerTr" align="right">
				<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:text>Kdvsiz İ.Sandık Tutarı&#160;</xsl:text></span></td>
				<td id="lineTableBudgetTd" style="width:85px;" align="right"><xsl:value-of select="format-number(cbc:Amount, '###.##0,00', 'european')"/><xsl:apply-templates select="." mode="CurrencyID"/></td>
			</tr>
			</xsl:if>
		</xsl:for-each>
	</xsl:if>

	<xsl:for-each select="cac:TaxTotal/cac:TaxSubtotal">
		<xsl:if test="cac:TaxCategory/cac:TaxScheme/cbc:Name='İ.Sandık KDV'">
		<tr id="budgetContainerTr" align="right">
			<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5">
				<span style="font-weight:bold;">
				<xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/><xsl:text> Matrahı</xsl:text>
				<xsl:if test="cbc:Percent != 0"><xsl:text>(%</xsl:text><xsl:value-of select="cbc:Percent"/><xsl:text>)</xsl:text></xsl:if><xsl:text>&#160;</xsl:text></span>
			</td>
			<td id="lineTableBudgetTd" style="width:85px;" align="right">
				<xsl:for-each select="cac:TaxCategory/cac:TaxScheme">
				<xsl:text> </xsl:text>
				<xsl:value-of select="format-number(../../cbc:TaxableAmount, '###.##0,00', 'european')"/>
				<xsl:apply-templates select="../../cbc:TaxableAmount" mode="CurrencyID"/>
				</xsl:for-each>
			</td>
		</tr>
		</xsl:if>
	<xsl:if test="cbc:TaxAmount != 0">
	<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5">
			<span style="font-weight:bold;">
			<xsl:if test="$sablonturu!='K'"><xsl:text>Hesaplanan </xsl:text></xsl:if>
			<xsl:if test="$sablonturu='K'"><xsl:text>İade Edilen </xsl:text></xsl:if>
			<xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>
			<xsl:if test="cbc:Percent != 0"><xsl:text>(%</xsl:text><xsl:value-of select="cbc:Percent"/><xsl:text>)</xsl:text></xsl:if><xsl:text>&#160;</xsl:text></span>
		</td>
		<td id="lineTableBudgetTd" style="width:85px;" align="right">
			<xsl:for-each select="cac:TaxCategory/cac:TaxScheme">
			<xsl:text> </xsl:text>
			<xsl:value-of select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')"/>
			<xsl:apply-templates select="../../cbc:TaxAmount" mode="CurrencyID"/>
			</xsl:for-each>
		</td>
	</tr>
	</xsl:if>
	</xsl:for-each>

	<xsl:for-each select="cac:WithholdingTaxTotal/cac:TaxSubtotal">
	<xsl:if test="cbc:TaxAmount != 0">
	<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5">
			<span style="font-weight:bold;"><xsl:text>KDV Tevkifatı [</xsl:text><xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode"/><xsl:text>]</xsl:text>
			<xsl:if test="cbc:Percent != 0"><xsl:text>(%</xsl:text><xsl:value-of select="cbc:Percent"/><xsl:text>)</xsl:text></xsl:if><xsl:text>&#160;</xsl:text></span>
		</td>
		<td id="lineTableBudgetTd" style="width:85px;" align="right">
			<xsl:for-each select="cac:TaxCategory/cac:TaxScheme">
			<xsl:text> </xsl:text>
			<xsl:value-of select="format-number(../../cbc:TaxAmount, '###.##0,00', 'european')"/>
			<xsl:apply-templates select="../../cbc:TaxAmount" mode="CurrencyID"/>
			</xsl:for-each>
		</td>
	</tr>
	</xsl:if>
	</xsl:for-each>

	<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:text>Vergiler Dahil Toplam Tutar&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" style="width:85px;" align="right">
			<xsl:for-each select="cac:LegalMonetaryTotal">
			<xsl:for-each select="cbc:TaxInclusiveAmount">
			<xsl:if test=".!=''">
			<xsl:value-of select="format-number(., '###.##0,00', 'european')"/>
			<xsl:apply-templates select="." mode="CurrencyID"/></xsl:if>
			</xsl:for-each>
			</xsl:for-each>
		</td>
	</tr>
	<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5;border-bottom-left-radius:8px"><span style="font-weight:bold;"><xsl:text>Ödenecek Tutar&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" style="width:85px; " align="right">
			<xsl:for-each select="cac:LegalMonetaryTotal">
			<xsl:for-each select="cbc:PayableAmount">
			<xsl:if test=".!=''">
			<xsl:value-of select="format-number(., '###.##0,00', 'european')"/>
			<xsl:apply-templates select="." mode="CurrencyID"/></xsl:if>
			</xsl:for-each>
			</xsl:for-each>
		</td>
	</tr>

	<xsl:if test="cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID != 'TRY'">
	<tr align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:text>Mal Toplam Tutarı(TL)&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" style="width:85px; " align="right"><span>
			<xsl:value-of select="format-number(cac:LegalMonetaryTotal/cbc:LineExtensionAmount * cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
			<xsl:text> TL&#160;</xsl:text></span>
		</td>
	</tr>
	<tr id="budgetContainerTr" align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5"><span style="font-weight:bold;"><xsl:text>Vergiler Dahil Toplam Tutar(TL)&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" style="width:85px; " align="right">
			<xsl:value-of select="format-number(cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount * cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
			<xsl:text> TL&#160;</xsl:text>
		</td>
	</tr>
	<tr align="right">
		<td id="lineTableBudgetTd" align="right" style="width:195px;background-color: #8BBFD5;border-top-left-radius:8px"><span style="font-weight:bold;"><xsl:text>Ödenecek Tutar(TL)&#160;</xsl:text></span></td>
		<td id="lineTableBudgetTd" style="width:85px; " align="right">
			<xsl:value-of select="format-number(cac:LegalMonetaryTotal/cbc:PayableAmount * cac:PricingExchangeRate/cbc:CalculationRate, '###.##0,00', 'european')"/>
			<xsl:text> TL&#160;</xsl:text>
		</td>
	</tr>
	</xsl:if>
	</tbody></table>
</xsl:template>
<!--*************************************** FOOTERRIGHT ******************************* -->

<!--*************************************** FOOTERTOPLAM ****************************** -->
<xsl:template match="*" mode="FooterToplam">
	<table id="budgetContainerTable"><tbody>
	<tr id="budgetContainerTr">
		<td id="lineTableBudgetTd" width="70px"><span style="font-weight:bold;"><xsl:text>&#160;Ambar No</xsl:text></span></td>
		<td id="lineTableBudgetTd" width="70px"><xsl:text>&#160;</xsl:text><xsl:value-of select="$ambarno"/></td>
		<td id="lineTableBudgetTd" width="50px"><span style="font-weight:bold;"><xsl:text>&#160;Plaka</xsl:text></span></td>
		<td id="lineTableBudgetTd" width="70px"><xsl:text>&#160;</xsl:text><xsl:value-of select="$plakano"/></td>
		<xsl:if test="$projeturu='B'">
			<td id="lineTableBudgetTd" width="50px"><span style="font-weight:bold;"><xsl:text>&#160;Kasa</xsl:text></span></td>
			<td id="lineTableBudgetTd" width="70px"><xsl:if test="@kasa!=''"><xsl:text>&#160;</xsl:text><xsl:value-of select="@kasa"/></xsl:if></td>
			<td id="lineTableBudgetTd" width="50px"><span style="font-weight:bold;"><xsl:text>&#160;Bağ</xsl:text></span></td>
			<td id="lineTableBudgetTd" width="70px"><xsl:if test="$bag!=''"><xsl:text>&#160;</xsl:text><xsl:value-of select="$bag"/></xsl:if></td>
		</xsl:if>
		<td id="lineTableBudgetTd" width="50px"><span style="font-weight:bold;"><xsl:text>&#160;Adet</xsl:text></span></td>
		<td id="lineTableBudgetTd" width="70px"><xsl:if test="$adet!=''"><xsl:text>&#160;</xsl:text><xsl:value-of select="$adet"/></xsl:if></td>
		<td id="lineTableBudgetTd" width="50px"><span style="font-weight:bold;"><xsl:text>&#160;Kilo</xsl:text></span></td>
		<td id="lineTableBudgetTd" width="70px"><xsl:if test="$kilo!=''"><xsl:text>&#160;</xsl:text><xsl:value-of select="$kilo"/></xsl:if></td>
	</tr>
	</tbody></table>
</xsl:template>
<!--*************************************** FOOTERTOPLAM ****************************** -->

<!--*************************************** FOOTERACIKLAMA **************************** -->
<xsl:template match="*" mode="FooterAciklama">
	<xsl:if test="cbc:Note!='' or cbc:InvoiceTypeCode='TEVKIFAT' or cac:Delivery/cac:DeliveryAddress">
		<tr><td align="left" colspan="3" style="border:0px;padding:0px">
			<fieldset style="border-radius:8px; border:1px solid black;padding:5px">
				<table border="0" width="100%">
					<xsl:if test="cbc:InvoiceTypeCode='TEVKIFAT'">
					<tr><td>
						<span style="font-weight:bold;"><xsl:text>Tevkifat Sebebi:</xsl:text></span>
						<xsl:for-each select="cac:WithholdingTaxTotal/cac:TaxSubtotal">
						<xsl:if test="cbc:TaxAmount != 0">
						<xsl:text>&#160;</xsl:text><xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>
						</xsl:if>
						</xsl:for-each>
					</td></tr>
					</xsl:if>

					<xsl:for-each select="cac:Delivery/cac:DeliveryAddress">
						<tr><td><span style="font-weight:bold;"><xsl:text>Sevk Adresi:&#160;</xsl:text></span>
						        <xsl:apply-templates select="."/></td></tr>
					</xsl:for-each>

					<xsl:for-each select="cbc:Note">
					<xsl:if test=".!=''"><tr><td><xsl:apply-templates select="."/></td></tr></xsl:if>
					</xsl:for-each>
				</table>
			</fieldset>
		</td></tr>
	</xsl:if>
</xsl:template>
<!--*************************************** FOOTERACIKLAMA **************************** -->

<!--*************************************** BANKAHESAP ******************************** -->
<xsl:template match="*" mode="BankaHesap">
	<xsl:if test="./cac:PaymentMeans">
		<tr><td align="left" colspan="3" style="border:0px;padding:0px">
			<fieldset style="border-radius:8px; border:1px solid black;padding:5px">
				<table border="0" width="100%">
					<xsl:if test="$ozelmusteri!='1' and ./cac:PaymentMeans[1]/cbc:PaymentDueDate!=''">
					<tr>
						<td colspan="3" style="border-width:1px; border-bottom:1px solid #000000;">
							<span style="font-weight:bold;"><xsl:text>Vade:&#160;</xsl:text></span>
							<xsl:apply-templates select="./cac:PaymentMeans[1]/cbc:PaymentDueDate" mode="Tarih"/>
							<xsl:text>&#160;(</xsl:text><xsl:value-of select="./cac:PaymentMeans[1]/cbc:InstructionNote"/><xsl:text>)</xsl:text>
						</td>
					</tr>
					</xsl:if>

				<xsl:for-each select="./cac:PaymentMeans">
					<tr>
						<td><xsl:value-of select="cac:PayeeFinancialAccount/cac:FinancialInstitutionBranch/cac:FinancialInstitution/cbc:Name"/></td>
						<td><xsl:value-of select="cac:PayeeFinancialAccount/cac:FinancialInstitutionBranch/cbc:Name"/></td>
						<td><xsl:value-of select="cac:PayeeFinancialAccount/cbc:ID"/></td>
					</tr>
				</xsl:for-each>
				</table>
			</fieldset>
		</td></tr>
	</xsl:if>
</xsl:template>
<!--*************************************** BANKAHESAP ******************************** -->

<!--*************************************** SAMEIRSALIYE ****************************** -->
<xsl:template match="*" mode="SameIrsaliye">
	<tr><td align="left" colspan="3" style="border:0px;padding:0px">
		<table border="0" width="100%"><tr>
			<xsl:if test="cbc:ProfileID='EARSIVFATURA'"><td align="left"><xsl:text>e-Arşiv izni kapsamında elektronik ortamda iletilmiştir.</xsl:text></td></xsl:if>
			<td align="left">
				<xsl:for-each select="cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory">
				<xsl:if test="cbc:TaxExemptionReason!=''">
					<span style="font-weight:bold"><xsl:value-of select="cac:TaxScheme/cbc:Name"/><xsl:text> Muafiyeti: </xsl:text></span>
					<xsl:value-of select="cbc:TaxExemptionReasonCode"/><xsl:text>&#160;</xsl:text><xsl:value-of select="cbc:TaxExemptionReason"/>
				</xsl:if>
				</xsl:for-each>
			</td>
			<xsl:if test="cbc:ProfileID!='IHRACAT'">
				<td align="right">
					<xsl:text>Tarih:</xsl:text>
					<xsl:if test="cac:DespatchDocumentReference/cbc:IssueDate!=''">
						<xsl:apply-templates select="cac:DespatchDocumentReference/cbc:IssueDate"/>
					</xsl:if>
					<xsl:if test="cac:DespatchDocumentReference/cbc:IssueDate='' or count(cac:DespatchDocumentReference)=0">
						<xsl:apply-templates select="cbc:IssueDate"/>
					</xsl:if>
					<xsl:text>&#160;Saat:</xsl:text><xsl:apply-templates select="cbc:IssueTime"/>
					<xsl:text>&#160;İrsaliye yerine geçer.</xsl:text>
				</td>
			</xsl:if>
		</tr></table>
	</td></tr>
</xsl:template>
<!--*************************************** SAMEIRSALIYE ****************************** -->

<!--*************************************** SATIRLAR ********************************** -->
<xsl:template match="cac:InvoiceLine">
	<xsl:variable name="extvaluesatir">
		<xsl:for-each select="cac:Item/cac:AdditionalItemIdentification[cbc:ID/@schemeID='EXTVALUE']"><xsl:value-of select="cbc:ID"/></xsl:for-each>
	</xsl:variable>
	<xsl:variable name="kasaadetsatir">
		<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvaluesatir,2,10))"/></xsl:call-template>
	</xsl:variable>
	<xsl:variable name="bagkilosatir">
		<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvaluesatir,12,10))"/></xsl:call-template>
	</xsl:variable>
	<xsl:variable name="darasatir">
		<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvaluesatir,22,10))"/></xsl:call-template>
	</xsl:variable>
	<xsl:variable name="kilosatir">
		<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvaluesatir,32,10))"/></xsl:call-template>
	</xsl:variable>
	<xsl:variable name="birimsatir">
		<xsl:value-of select="normalize-space(substring($extvaluesatir,42,10))"/>
	</xsl:variable>
	<xsl:variable name="kabirimsatir">
		<xsl:value-of select="normalize-space(substring($extvaluesatir,52,2))"/>
	</xsl:variable>
	<xsl:variable name="bkbirimsatir">
		<xsl:value-of select="normalize-space(substring($extvaluesatir,54,2))"/>
	</xsl:variable>
	<xsl:variable name="bagnetkilosatir">
		<xsl:choose>
			<xsl:when test="$daragoster='1'"><xsl:value-of select="$bagkilosatir"/></xsl:when>
			<xsl:otherwise><xsl:value-of select="$kilosatir"/></xsl:otherwise>
		</xsl:choose>
	</xsl:variable>

	<xsl:if test="$sablonturu='N'">
		<tr id="lineTableTr">
			<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text><xsl:value-of select="cac:Item/cbc:Name"/></span></td>
			<xsl:if test="$ozelmusteri='1'">
				<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text><xsl:value-of select="cac:Item/cac:BuyersItemIdentification/cbc:ID"/></span></td>
			</xsl:if>
			<xsl:if test="$satiraciklama='1'">
				<td id="lineTableTd"><xsl:text>&#160;</xsl:text><xsl:value-of select="cbc:Note"/></td>
			</xsl:if>
			<td id="lineTableTd" align="right"><span><xsl:value-of select="format-number(cbc:InvoicedQuantity, '###.##0,#########', 'european')"/><xsl:text>&#160;</xsl:text></span></td>
			<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text><xsl:value-of select="$birimsatir"/></span></td>
			<td id="lineTableTd" align="right" style="white-space:nowrap">
				<xsl:if test="cac:Price/cbc:PriceAmount!=''">
					<span>
						<xsl:value-of select="format-number(cac:Price/cbc:PriceAmount, '###.##0,00#######', 'european')"/>
						<xsl:apply-templates select="cac:Price/cbc:PriceAmount" mode="CurrencyIDTLYok"/>
					</span>
				</xsl:if>
			</td>

			<xsl:if test="//n1:Invoice/cbc:ProfileID!='IHRACAT'">
			<td id="lineTableTd" align="right" style="white-space:nowrap">
				<span>
				<xsl:for-each select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
					<xsl:if test="cbc:TaxTypeCode='0015'"><xsl:text> </xsl:text>
					<xsl:if test="../../cbc:Percent!=0"><xsl:text> %</xsl:text><xsl:value-of select="format-number(../../cbc:Percent, '###.##0,##', 'european')"/></xsl:if>
					</xsl:if>
				</xsl:for-each>
				<xsl:text>&#160;</xsl:text>
				</span>
			</td>
			</xsl:if>

			<xsl:if test="cac:AllowanceCharge">
				<td id="lineTableTd" align="right">
				<xsl:if test="cac:AllowanceCharge/cbc:ChargeIndicator='false'">
				<xsl:if test="cac:AllowanceCharge/cbc:Amount!=''">
				<span><xsl:value-of select="format-number(cac:AllowanceCharge/cbc:Amount, '###.##0,00##', 'european')"/><xsl:text>&#160;</xsl:text></span></xsl:if></xsl:if>
				</td>
			</xsl:if>

			<xsl:if test="//n1:Invoice/cbc:ProfileID='IHRACAT'">
				<td id="lineTableTd" align="center">
					<xsl:for-each select="cac:Delivery/cac:DeliveryTerms">
						<xsl:value-of select="cbc:ID"/><xsl:text>&#160;</xsl:text>
					</xsl:for-each>
				</td>
				<td id="lineTableTd" align="center">
					<xsl:for-each select="cac:Delivery/cac:Shipment/cac:TransportHandlingUnit">
					<xsl:for-each select="cac:ActualPackage">
						<xsl:value-of select="cbc:PackagingTypeCode"/><xsl:text>&#160;</xsl:text>
					</xsl:for-each>
					</xsl:for-each>
				</td>
				<td id="lineTableTd">
					<xsl:for-each select="cac:Delivery/cac:Shipment/cac:TransportHandlingUnit">
					<xsl:for-each select="cac:ActualPackage">
						<xsl:value-of select="cbc:ID"/><xsl:text>&#160;</xsl:text>
					</xsl:for-each>
					</xsl:for-each>
				</td>
				<td id="lineTableTd" align="center">
					<xsl:for-each select="cac:Delivery/cac:Shipment/cac:TransportHandlingUnit">
					<xsl:for-each select="cac:ActualPackage">
						<xsl:value-of select="cbc:Quantity"/><xsl:text>&#160;</xsl:text>
					</xsl:for-each>
					</xsl:for-each>
				</td>
				<td id="lineTableTd">
					<xsl:for-each select="cac:Delivery/cac:Shipment/cac:ShipmentStage">
						<xsl:value-of select="cbc:TransportModeCode/@listID"/><xsl:text>&#160;</xsl:text>
					</xsl:for-each>
				</td>
				<td id="lineTableTd">
					<xsl:for-each select="cac:Delivery/cac:Shipment/cac:GoodsItem">
						<xsl:value-of select="cbc:RequiredCustomsID"/><xsl:text>&#160;</xsl:text>
					</xsl:for-each>
				</td>
			</xsl:if>

			<td id="lineTableTd" align="right"><xsl:if test="cbc:LineExtensionAmount!=''"><span><xsl:value-of select="format-number(cbc:LineExtensionAmount, '###.##0,00', 'european')"/><xsl:text>&#160;</xsl:text></span></xsl:if></td>
		</tr>

		<xsl:if test="//n1:Invoice/cbc:ProfileID='IHRACAT'">
		<tr id="lineTableTr">
			<td id="lineTableTd" colspan="30">
			<xsl:for-each select="cac:Item/cac:AdditionalItemIdentification">
				<xsl:if test="cbc:ID/@schemeID='KUNYENO' and cbc:ID!=''"><span style="font-weight:bold;"><xsl:text>&#160;Künye:&#160;</xsl:text></span><xsl:value-of select="cbc:ID"/></xsl:if>
			</xsl:for-each>

			<xsl:for-each select="cac:Delivery/cac:DeliveryAddress">
				<span style="font-weight:bold;"><xsl:text>&#160;Teslim/Bedel Ödeme Yeri:&#160;</xsl:text></span><xsl:apply-templates select="."/><xsl:text>&#160;</xsl:text>
			</xsl:for-each>
			</td>
		</tr>
		<tr id="lineTableTr">
			<td id="lineTableTd" colspan="30"><xsl:text>&#160;</xsl:text></td>
		</tr>
		</xsl:if>
	</xsl:if>

	<xsl:if test="$sablonturu='H'">
		<tr id="lineTableTr">
			<xsl:if test="$markagoster='1'">
				<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text><xsl:value-of select="cac:Item/cbc:BrandName"/></span></td>
			</xsl:if>
			<xsl:if test="$ozelmusteri='1'">
				<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text><xsl:value-of select="cac:Item/cac:BuyersItemIdentification/cbc:ID"/></span></td>
			</xsl:if>
			<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text><xsl:value-of select="cac:Item/cbc:Name"/></span></td>
			<xsl:if test="$satiraciklama='1'">
				<td id="lineTableTd"><xsl:text>&#160;</xsl:text><xsl:value-of select="cbc:Note"/></td>
			</xsl:if>
			<td id="lineTableTd"><xsl:text>&#160;</xsl:text><xsl:for-each select="cac:Item/cac:AdditionalItemIdentification[cbc:ID/@schemeID='KUNYENO']"><xsl:value-of select="cbc:ID"/></xsl:for-each></td>
			<td id="lineTableTd" align="right"><span><xsl:value-of select="$kasaadetsatir"/><xsl:text>&#160;</xsl:text><xsl:value-of select="$kabirimsatir"/></span></td>
			<td id="lineTableTd" align="right"><span><xsl:value-of select="$bagnetkilosatir"/><xsl:text>&#160;</xsl:text><xsl:value-of select="$bkbirimsatir"/></span></td>
			<xsl:if test="$daragoster='1'">
				<td id="lineTableTd" align="right"><span><xsl:value-of select="$darasatir"/><xsl:text>&#160;</xsl:text></span></td>
				<td id="lineTableTd" align="right"><span><xsl:value-of select="$kilosatir"/><xsl:text>&#160;</xsl:text></span></td>
			</xsl:if>
			<td id="lineTableTd" align="right" style="white-space:nowrap">
				<xsl:if test="cac:Price/cbc:PriceAmount!=''">
					<span>
						<xsl:value-of select="format-number(cac:Price/cbc:PriceAmount, '###.##0,00#######', 'european')"/>
						<xsl:apply-templates select="cac:Price/cbc:PriceAmount" mode="CurrencyIDTLYok"/>
					</span>
				</xsl:if>
			</td>
			<td id="lineTableTd" align="right" style="white-space:nowrap">
				<span>
				<xsl:for-each select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
					<xsl:if test="cbc:TaxTypeCode='0015'"><xsl:text> </xsl:text>
					<xsl:if test="../../cbc:Percent!=0"><xsl:text> %</xsl:text><xsl:value-of select="format-number(../../cbc:Percent, '###.###,##', 'european')"/></xsl:if>
					</xsl:if>
				</xsl:for-each>
				<xsl:text>&#160;</xsl:text>
				</span>
			</td>
			<td id="lineTableTd" align="right"><xsl:if test="cbc:LineExtensionAmount!=''"><span><xsl:value-of select="format-number(cbc:LineExtensionAmount, '###.##0,00', 'european')"/><xsl:text>&#160;</xsl:text></span></xsl:if></td>
		</tr>
	</xsl:if>

	<xsl:if test="$sablonturu='K'">
		<tr id="lineTableTr">
			<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text><xsl:value-of select="cac:Item/cbc:Name"/></span></td>
			<td id="lineTableTd"><span><xsl:text>&#160;</xsl:text>
			<xsl:for-each select="cac:Item/cac:AdditionalItemIdentification">
				<xsl:if test="cbc:ID/@schemeID='KUNYENO'"><xsl:value-of select="cbc:ID"/></xsl:if>
			</xsl:for-each></span></td>
			<td id="lineTableTd" align="right"><span><xsl:value-of select="$kasaadetsatir"/><xsl:text>&#160;</xsl:text><xsl:value-of select="$kabirimsatir"/></span></td>
			<td id="lineTableTd" align="right"><span><xsl:value-of select="$bagkilosatir"/><xsl:text>&#160;</xsl:text><xsl:value-of select="$bkbirimsatir"/></span></td>
			<td id="lineTableTd" align="right" style="white-space:nowrap">
				<xsl:if test="cac:Price/cbc:PriceAmount!=''">
					<span>
						<xsl:value-of select="format-number(cac:Price/cbc:PriceAmount, '###.##0,00#######', 'european')"/>
						<xsl:apply-templates select="cac:Price/cbc:PriceAmount" mode="CurrencyIDTLYok"/>
					</span>
				</xsl:if>
			</td>
			<td id="lineTableTd" align="right" style="white-space:nowrap">
				<span>
				<xsl:for-each select="./cac:TaxTotal/cac:TaxSubtotal/cac:TaxCategory/cac:TaxScheme">
					<xsl:if test="cbc:TaxTypeCode='0015'"><xsl:text> </xsl:text>
					<xsl:if test="../../cbc:Percent!=0"><xsl:text> %</xsl:text><xsl:value-of select="format-number(../../cbc:Percent, '###.###,##', 'european')"/></xsl:if>
					</xsl:if>
				</xsl:for-each>
				<xsl:text>&#160;</xsl:text>
				</span>
			</td>
			<td id="lineTableTd" align="right"><xsl:if test="cbc:LineExtensionAmount!=''"><span><xsl:value-of select="format-number(cbc:LineExtensionAmount, '###.##0,00', 'european')"/><xsl:text>&#160;</xsl:text></span></xsl:if></td>
		</tr>
	</xsl:if>
</xsl:template>
<!--*************************************** SATIRLAR ********************************** -->

<!--*************************************** GİB LOGO ******************************** -->
<xsl:template match="//n1:Invoice" mode="Logo">
	<img style="width:91px"
        src="data:image/jpeg;base64,/9j/4QAYRXhpZgAASUkqAAgAAAAAAAAAAAAAAP/sABFEdWNreQABAAQAAABkAAD/4QMZaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLwA8P3hwYWNrZXQgYmVnaW49Iu+7vyIgaWQ9Ilc1TTBNcENlaGlIenJlU3pOVGN6a2M5ZCI/PiA8eDp4bXBtZXRhIHhtbG5zOng9ImFkb2JlOm5zOm1ldGEvIiB4OnhtcHRrPSJBZG9iZSBYTVAgQ29yZSA1LjYtYzEzMiA3OS4xNTkyODQsIDIwMTYvMDQvMTktMTM6MTM6NDAgICAgICAgICI+IDxyZGY6UkRGIHhtbG5zOnJkZj0iaHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyI+IDxyZGY6RGVzY3JpcHRpb24gcmRmOmFib3V0PSIiIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdFJlZj0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlUmVmIyIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bXBNTTpEb2N1bWVudElEPSJ4bXAuZGlkOjZDNDJBNEI2QjVCRDExRThCQjM0REIwQkZGMEQxODY0IiB4bXBNTTpJbnN0YW5jZUlEPSJ4bXAuaWlkOjZDNDJBNEI1QjVCRDExRThCQjM0REIwQkZGMEQxODY0IiB4bXA6Q3JlYXRvclRvb2w9IkFkb2JlIFBob3Rvc2hvcCBDUzQgV2luZG93cyI+IDx4bXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSIzREVENkU1N0FDREVDNEJBNzkxNUM2M0NCN0RENzM0NyIgc3RSZWY6ZG9jdW1lbnRJRD0iM0RFRDZFNTdBQ0RFQzRCQTc5MTVDNjNDQjdERDczNDciLz4gPC9yZGY6RGVzY3JpcHRpb24+IDwvcmRmOlJERj4gPC94OnhtcG1ldGE+IDw/eHBhY2tldCBlbmQ9InIiPz7/7gAOQWRvYmUAZMAAAAAB/9sAhAABAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEB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"/>
	<h1><span style="font-weight:bold; ">
	<xsl:choose>
		<xsl:when test="cbc:ProfileID = 'EARSIVFATURA'"><xsl:text>e-ARŞİV FATURA</xsl:text></xsl:when>
		<xsl:otherwise><xsl:text>e-FATURA</xsl:text></xsl:otherwise>
	</xsl:choose>
	</span></h1>
</xsl:template>
<!--*************************************** GİB LOGO ******************************** -->

<!--*************************************** QRCODE ******************************** -->
<xsl:template match="//n1:Invoice" mode="QrCode">
  <div id="qrcode"></div>
  <div id="qrvalue" style="display: none;">
{"tur":"E-Fatura",
"VKNTCKN":"<xsl:value-of select="cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='TCKN' or @schemeID='VKN']"/>",
"unvan":"<xsl:value-of select="translate(cac:AccountingSupplierParty/cac:Party/cac:PartyName/cbc:Name,'ĞÜŞÇİÖğüşçıö','GUSCIOguscio')"/><xsl:value-of select="translate(cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:FirstName,'ĞÜŞÇİÖğüşçıö','GUSCIOguscio')"/><xsl:text> </xsl:text><xsl:value-of select="translate(cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:FamilyName,'ĞÜŞÇİÖğüşçıö','GUSCIOguscio')"/><xsl:value-of select="translate(cac:BuyerCustomerParty/cac:Party/cac:PartyName/cbc:Name,'ĞÜŞÇİÖğüşçıö','GUSCIOguscio')"/><xsl:value-of select="translate(cac:BuyerCustomerParty/cac:Party/cac:Person/cbc:FirstName,'ĞÜŞÇİÖğüşçıö','GUSCIOguscio')"/><xsl:text> </xsl:text><xsl:value-of select="translate(cac:BuyerCustomerParty/cac:Party/cac:Person/cbc:FamilyName,'ĞÜŞÇİÖğüşçıö','GUSCIOguscio')"/>",
"senaryo":"<xsl:value-of select="cbc:ProfileID"/>",
"tip":"<xsl:value-of select="cbc:InvoiceTypeCode"/>",
"tarih":"<xsl:value-of select="cbc:IssueDate"/>",
"no":"<xsl:value-of select="cbc:ID"/>",
"ETTN":"<xsl:value-of select="cbc:UUID"/>",<xsl:for-each select="cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode='0015']">
"<xsl:text>malHizmet</xsl:text><xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>(<xsl:value-of select="cbc:Percent"/>)":<xsl:value-of select="cbc:TaxableAmount"/>,</xsl:for-each><xsl:for-each select="cac:TaxTotal/cac:TaxSubtotal[cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode='0015']">
"<xsl:text>hesaplanan</xsl:text><xsl:value-of select="cac:TaxCategory/cac:TaxScheme/cbc:Name"/>(<xsl:value-of select="cbc:Percent"/>)":<xsl:value-of select="cbc:TaxAmount"/>,</xsl:for-each>
"malHizmet":<xsl:value-of select="cac:LegalMonetaryTotal/cbc:LineExtensionAmount"/>,
"vergidahil":"<xsl:value-of select="cac:LegalMonetaryTotal/cbc:TaxInclusiveAmount"/>",
"odenecek":"<xsl:value-of select="cac:LegalMonetaryTotal/cbc:PayableAmount"/>"}
  </div>
  <script type="text/javascript">
    var qrcode = new QRCode(document.getElementById("qrcode"), {
    width : 140,
    height : 140,
    correctLevel : QRCode.CorrectLevel.M
    });

    function makeCode (msg) {
      qrcode.makeCode(msg);
    }
    makeCode(document.getElementById("qrvalue").innerHTML);
  </script>
</xsl:template>
<!--*************************************** QRCODE ******************************** -->

<!--*************************************** LOGO VE FİRMA ************************* -->
<xsl:template match="//n1:Invoice" mode="LogoVeFirma">
	<table><tr>
		<td align="left" valign="middle"><xsl:apply-templates select="." mode="FirmaLogo"/></td>
		<td align="left" valign="top" width="100%"><xsl:apply-templates select="cac:AccountingSupplierParty"/></td>
	</tr></table>
</xsl:template>
<!--*************************************** LOGO VE FİRMA ************************* -->

<!--*************************************** FİRMA LOGO ******************************** -->
<xsl:template match="//n1:Invoice" mode="FirmaLogo">
	 
			<img align="middle" src="data:image/jpeg;base64,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AGxmZgAGAAAAAAABAC9mZgABAKGZmgAGAAAAAAABADIAAAABAFoAAAAGAAAAAAABADUAAAABAC0AAAAGAAAAAAABOEJJTQP4AAAAAABwAAD/////////////////////////////A+gAAAAA/////////////////////////////wPoAAAAAP////////////////////////////8D6AAAAAD/////////////////////////////A+gAADhCSU0EAAAAAAAAAgADOEJJTQQCAAAAAAAIAAAAAAAAAAA4QklNBDAAAAAAAAQBAQEBOEJJTQQtAAAAAAACAAA4QklNBAgAAAAAABAAAAABAAACQAAAAkAAAAAAOEJJTQQeAAAAAAAEAAAAADhCSU0EGgAAAAADSQAAAAYAAAAAAAAAAAAAAJYAAACWAAAACgBVAG4AdABpAHQAbABlAGQALQAxAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAACWAAAAlgAAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAAAAAAAAAAAABAAAAABAAAAAAAAbnVsbAAAAAIAAAAGYm91bmRzT2JqYwAAAAEAAAAAAABSY3QxAAAABAAAAABUb3AgbG9uZwAAAAAAAAAATGVmdGxvbmcAAAAAAAAAAEJ0b21sb25nAAAAlgAAAABSZ2h0bG9uZwAAAJYAAAAGc2xpY2VzVmxMcwAAAAFPYmpjAAAAAQAAAAAABXNsaWNlAAAAEgAAAAdzbGljZUlEbG9uZwAAAAAAAAAHZ3JvdXBJRGxvbmcAAAAAAAAABm9yaWdpbmVudW0AAAAMRVNsaWNlT3JpZ2luAAAADWF1dG9HZW5lcmF0ZWQAAAAAVHlwZWVudW0AAAAKRVNsaWNlVHlwZQAAAABJbWcgAAAABmJvdW5kc09iamMAAAABAAAAAAAAUmN0MQAAAAQAAAAAVG9wIGxvbmcAAAAAAAAAAExlZnRsb25nAAAAAAAAAABCdG9tbG9uZwAAAJYAAAAAUmdodGxvbmcAAACWAAAAA3VybFRFWFQAAAABAAAAAAAAbnVsbFRFWFQAAAABAAAAAAAATXNnZVRFWFQAAAABAAAAAAAGYWx0VGFnVEVYVAAAAAEAAAAAAA5jZWxsVGV4dElzSFRNTGJvb2wBAAAA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eG1wOk1vZGlmeURhdGU9IjIwMjAtMDEtMDlUMDg6MzA6MzMrMDM6MDAiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6MEQwMjFDODZBMDMyRUExMUJDQjRCMTVGMTMyRkJCOUYiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6MEMwMjFDODZBMDMyRUExMUJDQjRCMTVGMTMyRkJCOUYiIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDowQzAyMUM4NkEwMzJFQTExQkNCNEIxNUYxMzJGQkI5RiIgcGhvdG9zaG9wOkNvbG9yTW9kZT0iMyIgZGM6Zm9ybWF0PSJpbWFnZS9qcGVnIj4gPHhtcE1NOkhpc3Rvcnk+IDxyZGY6U2VxPiA8cmRmOmxpIHN0RXZ0OmFjdGlvbj0iY3JlYXRlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDowQzAyMUM4NkEwMzJFQTExQkNCNEIxNUYxMzJGQkI5RiIgc3RFdnQ6d2hlbj0iMjAyMC0wMS0wOVQwODozMDozMyswMzowMCIgc3RFdnQ6c29mdHdhcmVBZ2VudD0iQWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzIi8+IDxyZGY6bGkgc3RFdnQ6YWN0aW9uPSJzYXZlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDowRDAyMUM4NkEwMzJFQTExQkNCNEIxNUYxMzJGQkI5RiIgc3RFdnQ6d2hlbj0iMjAyMC0wMS0wOVQwODozMDozMyswMzowMCIgc3RFdnQ6c29mdHdhcmVBZ2VudD0iQWRvYmUgUGhvdG9zaG9wIENTNSBXaW5kb3dzIiBzdEV2dDpjaGFuZ2VkPSIvIi8+IDwvcmRmOlNlcT4gPC94bXBNTTpIaXN0b3J5PiA8cGhvdG9zaG9wOkRvY3VtZW50QW5jZXN0b3JzPiA8cmRmOkJhZz4gPHJkZjpsaT51dWlkOjYyYTliN2E3LWFlYmMtNDk3Zi04NTE4LTA4NjY2YTM3Njc2MDwvcmRmOmxpPiA8L3JkZjpCYWc+IDwvcGhvdG9zaG9wOkRvY3VtZW50QW5jZXN0b3JzPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA8P3hwYWNrZXQgZW5kPSJ3Ij8+/+4AIUFkb2JlAGRAAAAAAQMAEAMCAwYAAAAAAAAAAAAAAAD/2wCEAAEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQECAgICAgICAgICAgMDAwMDAwMDAwMBAQEBAQEBAQEBAQICAQICAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDA//CABEIAJYAlgMBEQACEQEDEQH/xAD3AAACAgMBAQEBAAAAAAAAAAAFBgcIBAkKAwIAAQEAAQQDAQEAAAAAAAAAAAAAAAQFBgcBAwgCCRAAAAcAAQMBBwMCBQUAAAAAAQIDBAUGBwgAEQkSECAhExQVCjEiFjAkQFA0FxhBMiMlGREAAQQBAwIEAwUDCgQEBwAAAQIDBAUGABEHIRIxQVETYSIIcZEyQhSBIxXwobHB0VJicjMW4ZIkCfHSQ4OColOzNCUXEgACAQIEBAMFBAgDBQYHAAABAgMRBAAhEgUxQRMGUWEicYEyFAeRQlIjECChscHRYhUw8OFAUHIzY4KSokMkFlOTNEQlJif/2gAMAwEBAhEDEQAAAOhsGMGADgFwLAVDIDMDyDzDDAeAoAoL4LoL4LwSMDGDADEDABkCeMfOnfl4yOZ3LD0eiMnZBWAPkDgvgsgtAthI4NYMYMQMAGNfoNEpG1PbZDNC3AIirvJl11s72dX0Z11ND1kQxa8i8C4CuC2Eigzg1gy+cMJ6OesVF4W6us91BQ2tj5g9/wD5Sktb1jzpXLne7L7/AEk4lITKGKSFcFWpFYFYFgJDBpBtBsxiMKFuJOrSeD4o862v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"/>
		 
</xsl:template>
<!--*************************************** FİRMA LOGO ******************************** -->

<!--*************************************** FİRMA KAŞE ******************************** -->
<xsl:template match="//n1:Invoice" mode="FirmaKase">
	<xsl:if test="cbc:ProfileID='EARSIVFATURA'"> 
			<img width="105px" align="middle" src="data:image/jpeg;base64,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AAAAAFJzbHRVbnRGI1B4bEBywAAAAAAAAAAACnZlY3RvckRhdGFib29sAQAAAABQZ1BzZW51bQAAAABQZ1BzAAAAAFBnUEMAAAAATGVmdFVudEYjUmx0AAAAAAAAAAAAAAAAVG9wIFVudEYjUmx0AAAAAAAAAAAAAAAAU2NsIFVudEYjUHJjQFkAAAAAAAA4QklNA+0AAAAAABABLAAAAAEAAgEsAAAAAQACOEJJTQQmAAAAAAAOAAAAAAAAAAAAAD+AAAA4QklNBA0AAAAAAAQAAAB4OEJJTQQZAAAAAAAEAAAAHjhCSU0D8wAAAAAACQAAAAAAAAAAAQA4QklNJxAAAAAAAAoAAQAAAAAAAAACOEJJTQP1AAAAAABIAC9mZgABAGxmZgAGAAAAAAABAC9mZgABAKGZmgAGAAAAAAABADIAAAABAFoAAAAGAAAAAAABADUAAAABAC0AAAAGAAAAAAABOEJJTQP4AAAAAABwAAD/////////////////////////////A+gAAAAA/////////////////////////////wPoAAAAAP////////////////////////////8D6AAAAAD/////////////////////////////A+gAADhCSU0EAAAAAAAAAgACOEJJTQQCAAAAAAAGAAAAAAAAOEJJTQQwAAAAAAADAQEBADhCSU0ELQAAAAAAAgAAOEJJTQQIAAAAAAAQAAAAAQAAAkAAAAJAAAAAADhCSU0EHgAAAAAABAAAAAA4QklNBBoAAAAAA0kAAAAGAAAAAAAAAAAAAACWAAAAlgAAAAoAVQBuAHQAaQB0AGwAZQBkAC0AMQAAAAEAAAAAAAAAAAAAAAAAAAAAAAAAAQAAAAAAAAAAAAAAlgAAAJYAAAAAAAAAAAAAAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAQAAAAAQAAAAAAAG51bGwAAAACAAAABmJvdW5kc09iamMAAAABAAAAAAAAUmN0MQAAAAQAAAAAVG9wIGxvbmcAAAAAAAAAAExlZnRsb25nAAAAAAAAAABCdG9tbG9uZwAAAJYAAAAAUmdodGxvbmcAAACWAAAABnNsaWNlc1ZsTHMAAAABT2JqYwAAAAEAAAAAAAVzbGljZQAAABIAAAAHc2xpY2VJRGxvbmcAAAAAAAAAB2dy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bWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgNS4wLWMwNjAgNjEuMTM0Nzc3LCAyMDEwLzAyLzEyLTE3OjMyOjAwICAgICAgICAiPiA8cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtbG5zOnhtcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxuczpzdEV2dD0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlRXZlbnQjIiB4bWxuczpkYz0iaHR0cDovL3B1cmwub3JnL2RjL2VsZW1lbnRzLzEuMS8iIHhtbG5zOnBob3Rvc2hvcD0iaHR0cDovL25zLmFkb2JlLmNvbS9waG90b3Nob3AvMS4wLyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ1M1IFdpbmRvd3MiIHhtcDpDcmVhdGVEYXRlPSIyMDIwLTAxLTE0VDE5OjI3OjIyKzAzOjAwIiB4bXA6TWV0YWRhdGFEYXRlPSIyMDIwLTAxLTE0VDE5OjI3OjIyKzAzOjAwIiB4bXA6TW9kaWZ5RGF0ZT0iMjAyMC0wMS0xNFQxOToyNzoyMiswMzowMCIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDo0NzgxRUNCREVBMzZFQTExODlENUUxOUVCNEU0ODU4MiIgeG1wTU06RG9jdW1lbnRJRD0ieG1wLmRpZDo0NjgxRUNCREVBMzZFQTExODlENUUxOUVCNEU0ODU4MiIgeG1wTU06T3JpZ2luYWxEb2N1bWVudElEPSJ4bXAuZGlkOjQ2ODFFQ0JERUEzNkVBMTE4OUQ1RTE5RUI0RTQ4NTgyIiBkYzpmb3JtYXQ9ImltYWdlL2pwZWciIHBob3Rvc2hvcDpDb2xvck1vZGU9IjMiPiA8eG1wTU06SGlzdG9yeT4gPHJkZjpTZXE+IDxyZGY6bGkgc3RFdnQ6YWN0aW9uPSJjcmVhdGVkIiBzdEV2dDppbnN0YW5jZUlEPSJ4bXAuaWlkOjQ2ODFFQ0JERUEzNkVBMTE4OUQ1RTE5RUI0RTQ4NTgyIiBzdEV2dDp3aGVuPSIyMDIwLTAxLTE0VDE5OjI3OjIyKzAzOjAwIiBzdEV2dDpzb2Z0d2FyZUFnZW50PSJBZG9iZSBQaG90b3Nob3AgQ1M1IFdpbmRvd3MiLz4gPHJkZjpsaSBzdEV2dDphY3Rpb249InNhdmVkIiBzdEV2dDppbnN0YW5jZUlEPSJ4bXAuaWlkOjQ3ODFFQ0JERUEzNkVBMTE4OUQ1RTE5RUI0RTQ4NTgyIiBzdEV2dDp3aGVuPSIyMDIwLTAxLTE0VDE5OjI3OjIyKzAzOjAwIiBzdEV2dDpzb2Z0d2FyZUFnZW50PSJBZG9iZSBQaG90b3Nob3AgQ1M1IFdpbmRvd3MiIHN0RXZ0OmNoYW5nZWQ9Ii8iLz4gPC9yZGY6U2VxPiA8L3htcE1NOkhpc3Rvcnk+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwveDp4bXBtZXRhPiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIDw/eHBhY2tldCBlbmQ9InciPz7/7gAhQWRvYmUAZEAAAAABAwAQAwIDBgAAAAAAAAAAAAAAAP/bAIQAAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQICAgICAgICAgICAwMDAwMDAwMDAwEBAQEBAQEBAQEBAgIBAgIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMD/8IAEQgAlgCWAwERAAIRAQMRAf/EANYAAQAC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"/>
	 
	</xsl:if>
</xsl:template>
<!--*************************************** FİRMA KAŞE ******************************** -->

<xsl:template match="cac:Person">
	<xsl:for-each select="cbc:Title"><xsl:apply-templates/><span><xsl:text>&#160;</xsl:text></span></xsl:for-each>
	<xsl:for-each select="cbc:FirstName"><xsl:apply-templates/><span><xsl:text>&#160;</xsl:text></span></xsl:for-each>
	<xsl:for-each select="cbc:MiddleName"><xsl:apply-templates/><span><xsl:text>&#160; </xsl:text></span></xsl:for-each>
	<xsl:for-each select="cbc:FamilyName"><xsl:apply-templates/><span><xsl:text>&#160;</xsl:text></span></xsl:for-each>
	<xsl:for-each select="cbc:NameSuffix"><xsl:apply-templates/></xsl:for-each>
</xsl:template>

<xsl:template match="*" mode="Adres">
	<xsl:for-each select="cbc:StreetName"><xsl:apply-templates/><span><xsl:text>&#160;</xsl:text></span></xsl:for-each>
	<xsl:for-each select="cbc:BuildingName"><xsl:apply-templates/></xsl:for-each>
	<xsl:if test="cbc:BuildingNumber"><span><xsl:text> No:</xsl:text></span>
	<xsl:for-each select="cbc:BuildingNumber"><xsl:apply-templates/></xsl:for-each>
	<span><xsl:text>&#160;</xsl:text></span>
	</xsl:if>
	<xsl:if test="cbc:Room"><span><xsl:text>Kapı No:</xsl:text></span>
	<xsl:for-each select="cbc:Room"><xsl:apply-templates/></xsl:for-each>
	<span><xsl:text>&#160;</xsl:text></span>
	</xsl:if>
	<br/>
	<xsl:if test="cbc:PostalZone != ''"><xsl:for-each select="cbc:PostalZone"><xsl:apply-templates/><span><xsl:text>&#160;</xsl:text></span></xsl:for-each></xsl:if>
	<xsl:for-each select="cbc:CitySubdivisionName"><xsl:apply-templates/></xsl:for-each>
	<span><xsl:text>/</xsl:text></span>
	<xsl:for-each select="cbc:CityName"><xsl:apply-templates/><span><xsl:text>&#160;</xsl:text></span></xsl:for-each>
</xsl:template>

<xsl:template match="cac:DeliveryAddress">
	<xsl:if test="//n1:Invoice/cbc:ProfileID!='IHRACAT'">
		<xsl:value-of select="cbc:StreetName"/>
	</xsl:if>
	<xsl:if test="cbc:CitySubdivisionName!=''">
		<xsl:apply-templates select="cbc:CitySubdivisionName"/>
		<span><xsl:text>/</xsl:text></span>
	</xsl:if>
	<xsl:apply-templates select="cbc:CityName"/><span><xsl:text>&#160;</xsl:text></span>
	<xsl:apply-templates select="cac:Country/cbc:Name"/><span><xsl:text>&#160;</xsl:text></span>
</xsl:template>

<xsl:template match="cac:Contact">
	<xsl:if test="cbc:Telephone">
	<tr align="left">
		<td style="width:469px;" align="left">
			<span><xsl:text>Tel: </xsl:text></span>
			<xsl:for-each select="cbc:Telephone"><xsl:apply-templates/></xsl:for-each>
			<span><xsl:text>&#160;</xsl:text></span>
		</td>
	</tr>
	</xsl:if>

	<xsl:if test="cbc:Telefax">
	<tr align="left">
		<td style="width:469px;" align="left">
			<span><xsl:text>Tel: </xsl:text></span>
			<xsl:for-each select="cbc:Telefax"><xsl:apply-templates/></xsl:for-each>
			<span><xsl:text>&#160;</xsl:text></span>
		</td>
	</tr>
	</xsl:if>
</xsl:template>

<xsl:template match="cac:Party">
	<table align="left" border="0"><tbody>
	<tr>
		<td align="left" style="font-weight: bold">
		<xsl:if test="cac:PartyName"><xsl:value-of select="cac:PartyName/cbc:Name"/><br/></xsl:if>
		<xsl:apply-templates select="cac:Person"/>
		</td>
	</tr>
	<tr><td align="left"><xsl:apply-templates select="cac:PostalAddress" mode="Adres"/></td></tr>

	<xsl:apply-templates select="cac:Contact"/>
	<xsl:for-each select="cbc:WebsiteURI"><tr align="left"><td><xsl:value-of select="."/></td></tr></xsl:for-each>
	<xsl:for-each select="cac:Contact/cbc:ElectronicMail"><tr align="left"><td><xsl:value-of select="."/></td></tr></xsl:for-each>

	<tr align="left">
		<td align="left">
		<xsl:if test="cac:PartyTaxScheme/cac:TaxScheme/cbc:Name != ''">
		<span><xsl:text>Vergi Dairesi: </xsl:text></span>
		<xsl:for-each select="cac:PartyTaxScheme">
			<xsl:for-each select="cac:TaxScheme"><xsl:for-each select="cbc:Name"><xsl:apply-templates/></xsl:for-each></xsl:for-each>
			<span><xsl:text>&#160; </xsl:text></span>
		</xsl:for-each>
        	</xsl:if>
		<xsl:for-each select="cac:PartyIdentification">
                  <xsl:if test="cbc:ID/@schemeID != 'MUSTERINO'">
			<xsl:value-of select="cbc:ID/@schemeID"/><xsl:text>:</xsl:text><xsl:value-of select="cbc:ID"/>
  		  </xsl:if>
		</xsl:for-each>
		</td>
	</tr>

	</tbody></table>
</xsl:template>

<!--*************************************** MÜŞTERİ *********************************** -->
<xsl:template match="cac:AccountingCustomerParty">
	<table id="customerPartyTable" align="left"><tbody>
	<tr><td align="left"><span style="font-weight:bold;"><xsl:text>SAYIN</xsl:text></span></td></tr>
	<tr><td><xsl:apply-templates select="cac:Party"/></td></tr>
	</tbody></table>
</xsl:template>
<!--*************************************** MÜŞTERİ *********************************** -->

<!--*************************************** FATURA SAHİBİ *********************************** -->
<xsl:template match="cac:AccountingSupplierParty">
	<table align="left" id="supplierPartyTable"><tbody>
	<tr><td><xsl:apply-templates select="cac:Party"/></td></tr>
	</tbody></table>
</xsl:template>
<!--*************************************** FATURA SAHİBİ *********************************** -->

<!--*************************************** ETTN ******************************************** -->
<xsl:template match="cbc:UUID">
	<table id="ettnTable"><tbody>
	<tr style="height:13px;">
		<td align="left" valign="top"><span style="font-weight:bold;"><xsl:text>ETTN:</xsl:text></span></td>
		<td align="left"><xsl:value-of select="."/></td>
	</tr>
	</tbody></table>
</xsl:template>
<!--*************************************** ETTN ******************************************** -->

<!--*************************************** FATURA BİLGİLERİ ******************************** -->
<xsl:template match="//n1:Invoice" mode="FaturaInfo">
	<table id="despatchTable" cellpadding="2"><tbody>
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Özelleştirme No</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cbc:CustomizationID"/></td></tr>
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Senaryo</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cbc:ProfileID"/></td></tr>
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Fatura Tipi</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cbc:InvoiceTypeCode"/></td></tr>
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Fatura No</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cbc:ID"/></td></tr>
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Fatura Tarihi</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:apply-templates select="cbc:IssueDate"/></td></tr>
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>İşlem Saati</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:apply-templates select="cbc:IssueTime"/></td></tr>
	<xsl:if test="cac:DespatchDocumentReference/cbc:ID!=''">
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>İrsaliye No</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cac:DespatchDocumentReference/cbc:ID"/></td></tr>
	<tr>
		<td align="left"><span style="font-weight:bold; "><xsl:text>İrsaliye Tarihi</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:apply-templates select="cac:DespatchDocumentReference/cbc:IssueDate"/></td></tr>
	</xsl:if>
	<xsl:if test="cac:OrderReference/cbc:ID!=''">
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Sipariş No</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cac:OrderReference/cbc:ID"/></td></tr>
	<tr>
		<td align="left"><span style="font-weight:bold; "><xsl:text>Sipariş Tarihi</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:apply-templates select="cac:OrderReference/cbc:IssueDate"/></td></tr>
	</xsl:if>
	<xsl:if test="$sablonturu!='K' and $odemeturu!='' and $ozelmusteri!='1' and cbc:ProfileID!='IHRACAT'">
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Ödeme Türü</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="$odemeturu"/></td></tr>
	</xsl:if>
	<xsl:apply-templates select="//n1:Invoice" mode="MusteriDetaySag"/>
	<xsl:if test="cac:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID != 'TRY'">
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Döviz Kuru</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cac:PricingExchangeRate/cbc:CalculationRate"/><xsl:text> TL</xsl:text></td></tr>
	</xsl:if>
	</tbody></table>
</xsl:template>

<xsl:template match="*" mode="MusteriDetaySag">
	<xsl:for-each select="cac:AdditionalDocumentReference">
	<xsl:if test="cbc:DocumentType='IRSALIYE'">
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>İrs. Matbu No</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="cbc:ID"/></td>
	</tr>
	</xsl:if>
	</xsl:for-each>

	<xsl:if test="$sablonturu='K'">
	<tr>
		<td align="left"><span style="font-weight:bold;"><xsl:text>Giriş Tarihi</xsl:text></span></td>
		<td><xsl:text>:</xsl:text></td>
		<td align="left"><xsl:value-of select="$ambargiristarihi"/></td>
	</tr>
	</xsl:if>
</xsl:template>
<!--*************************************** FATURA BİLGİLERİ ******************************** -->

<!--*************************************** MÜŞTERİ DETAY *********************************** -->
<xsl:template match="//n1:Invoice" mode="MusteriDetay">
	<tr align="left" valign="bottom">
		<td colspan="3">
			<table><tr>
				<xsl:for-each select="cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PartyIdentification">
				<xsl:if test="cbc:ID/@schemeID = 'BAYINO'">
				<td align="left" id="lineTableBudgetTd"><span style="font-weight:bold;"><xsl:text>Mağaza No:&#160;</xsl:text></span><xsl:value-of select="cbc:ID"/></td>
				<td></td>
				</xsl:if>

				<xsl:if test="cbc:ID/@schemeID = 'SUBENO'">
				<td align="left" id="lineTableBudgetTd"><span style="font-weight:bold;"><xsl:text>Şube:&#160;</xsl:text></span><xsl:value-of select="cbc:ID"/><xsl:text> - </xsl:text><xsl:value-of select="cbc:ID/@schemeName"/></td>
				<td></td>
				</xsl:if>
				</xsl:for-each>

				<xsl:for-each select="cac:ReceiptDocumentReference">
				<td align="left" id="lineTableBudgetTd"><span style="font-weight:bold;"><xsl:text>Mal Kabul No:&#160;</xsl:text></span><xsl:value-of select="cbc:ID"/></td>
				</xsl:for-each>

				<xsl:for-each select="cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification">
				<xsl:if test="cbc:ID/@schemeID = 'xMUSTERINOx'">
				<td align="left" id="lineTableBudgetTd"><span style="font-weight:bold;"><xsl:text>Satıcı No:&#160;</xsl:text></span><xsl:value-of select="cbc:ID"/></td>
				</xsl:if>
				</xsl:for-each>

			</tr></table>
		</td>
	</tr>
</xsl:template>
<!--*************************************** MÜŞTERİ DETAY *********************************** -->

<xsl:variable name="vergino">
	<xsl:for-each select="//n1:Invoice/cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification[cbc:ID/@schemeID='VKN']"><xsl:value-of select="cbc:ID"/></xsl:for-each>
</xsl:variable>
<xsl:variable name="ozelmusteri">
	<xsl:if test="$vergino='6200031354' or $vergino='6220529513' or $vergino='2030017071' or $vergino='7450149143' or $vergino='7450061854' or $vergino='1750051846' or $vergino='3940482658' or $vergino='4730030397' or $vergino='8450627145'"><xsl:text>1</xsl:text></xsl:if>
</xsl:variable>
<xsl:variable name="markagoster">
	<xsl:if test="$vergino!='1750051846' and $vergino!='3940482658'"><xsl:text>1</xsl:text></xsl:if>
</xsl:variable>
<xsl:variable name="daragoster">
	<xsl:if test="$vergino!='1750051846' and $vergino!='3940482658'"><xsl:text>1</xsl:text></xsl:if>
</xsl:variable>

<xsl:variable name="extvalue">
	<xsl:for-each select="//n1:Invoice/cac:AdditionalDocumentReference[cbc:DocumentType='EXTVALUE']"><xsl:value-of select="cbc:ID"/></xsl:for-each>
</xsl:variable>
<xsl:variable name="bakiye">
	<xsl:call-template name="mnumberBA"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,2,20))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="odemeturu">
	<xsl:value-of select="normalize-space(substring($extvalue,22,10))"/>
</xsl:variable>
<xsl:variable name="adet">
	<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,32,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="kilo">
	<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,42,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="plakano">
	<xsl:value-of select="normalize-space(substring($extvalue,52,10))"/>
</xsl:variable>
<xsl:variable name="hamaliyetutari">
	<xsl:call-template name="mnumber2D"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,62,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="hamaliyekdvorani">
	<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,72,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="nakliyetutari">
	<xsl:call-template name="mnumber2D"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,82,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="nakliyekdvorani">
	<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,92,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="isandiktutari">
	<xsl:call-template name="mnumber2D"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,102,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="isandikkdvorani">
	<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,112,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="kdvsizisandiktutari">
	<xsl:call-template name="mnumber2D"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,122,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="kasa">
	<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,132,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="bag">
	<xsl:call-template name="mnumber"><xsl:with-param name="numberstr" select="normalize-space(substring($extvalue,142,10))"/></xsl:call-template>
</xsl:variable>
<xsl:variable name="ambargiristarihi">
	<xsl:value-of select="normalize-space(substring($extvalue,152,10))"/>
</xsl:variable>
<xsl:variable name="ambarno">
	<xsl:value-of select="normalize-space(substring($extvalue,162,10))"/>
</xsl:variable>
<xsl:variable name="joker">
	<xsl:value-of select="normalize-space(substring($extvalue,172,10))"/>
</xsl:variable>
<xsl:variable name="projeturu">
	<xsl:value-of select="substring($joker,1,1)"/>
</xsl:variable>
<xsl:variable name="satiraciklama">
	<xsl:value-of select="substring($joker,2,1)"/>
</xsl:variable>
<xsl:variable name="xsablonturu">
	<xsl:value-of select="substring($joker,3,1)"/>
</xsl:variable>
<xsl:variable name="sablonturu">
	<xsl:choose>
		<xsl:when test="$xsablonturu='N' or $xsablonturu='H' or $xsablonturu='K'"><xsl:value-of select="$xsablonturu"/></xsl:when>
		<xsl:otherwise>N</xsl:otherwise>
	</xsl:choose>
</xsl:variable>

<xsl:template name="mnumber" >
  <xsl:param name="numberstr"/>
  <xsl:if test="$numberstr!='' and $vergino!='4730030397'">
	<xsl:value-of select="format-number(number($numberstr), '###.##0,#########', 'european')"/>
  </xsl:if>
  <xsl:if test="$numberstr!='' and $vergino='4730030397'"><xsl:value-of select="$numberstr"/></xsl:if>
</xsl:template>

<xsl:template name="mnumber2D" >
  <xsl:param name="numberstr"/>
  <xsl:if test="$numberstr!='' and $vergino!='4730030397'">
	<xsl:value-of select="format-number(number($numberstr), '###.##0,00#######', 'european')"/>
  </xsl:if>
  <xsl:if test="$numberstr!='' and $vergino='4730030397'"><xsl:value-of select="$numberstr"/></xsl:if>
</xsl:template>

<xsl:template name="mnumberBA" >
  <xsl:param name="numberstr"/>
  <xsl:if test="$numberstr!='' and $vergino!='4730030397'">
	<xsl:value-of select="format-number(number($numberstr), '###.##0,00', 'european')"/>
	<xsl:if test="number($numberstr)&gt;0"><xsl:text> Borç</xsl:text></xsl:if>
	<xsl:if test="number($numberstr)&lt;0"><xsl:text> Alacak</xsl:text></xsl:if>
  </xsl:if>
  <xsl:if test="$numberstr!='' and $vergino='4730030397'"><xsl:value-of select="$numberstr"/></xsl:if>
</xsl:template>

</xsl:stylesheet>
