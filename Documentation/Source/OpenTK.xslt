<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <!-- String replace template -->
  <!-- Not used yet, but can be useful for long function declarations -->
  <xsl:template name="globalReplace">
    <xsl:param name="outputString"/>
    <xsl:param name="target"/>
    <xsl:param name="replacement"/>
    <xsl:choose>
      <xsl:when test="contains($outputString,$target)">

        <xsl:value-of select=
        "concat(substring-before($outputString,$target),
               $replacement)"/>
        <xsl:call-template name="globalReplace">
          <xsl:with-param name="outputString"
               select="substring-after($outputString,$target)"/>
          <xsl:with-param name="target" select="$target"/>
          <xsl:with-param name="replacement"
               select="$replacement"/>
        </xsl:call-template>
      </xsl:when>
      <xsl:otherwise>
        <xsl:value-of select="$outputString"/>
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>
  
  <!-- Comment printer -->
  <xsl:template name="PrintComment">
    <xsl:param name="CommentType" />
    <xsl:if test="$CommentType!=''">
      <h4>
        <xsl:value-of select='name($CommentType)'/>: 
        <xsl:value-of select='$CommentType/@*'/>
      </h4>
      <xsl:value-of select="$CommentType" />
    </xsl:if>
  </xsl:template>

  <!-- Prints all comments associated with this type -->
  <xsl:template name="PrintAllComments">
    
    <xsl:call-template name='PrintComment'>
      <xsl:with-param name='CommentType' select='summary'/>
    </xsl:call-template>

    <xsl:for-each select='param'>
      <xsl:call-template name='PrintComment'>
        <xsl:with-param name='CommentType' select='.'/>
      </xsl:call-template>
    </xsl:for-each>

    <xsl:call-template name='PrintComment'>
      <xsl:with-param name='CommentType' select='returns'/>
    </xsl:call-template>

    <xsl:call-template name='PrintComment'>
      <xsl:with-param name='CommentType' select='remarks'/>
    </xsl:call-template>

  </xsl:template>

  <!-- Prints documentation for a type. -->
  <xsl:template name='DocumentationSection'>

    <!--<xsl:apply-templates select='*/members'/>-->
    <xsl:for-each select='members/*'>

      <xsl:sort select='@name'/>
      <xsl:if test="starts-with(@name, 'T')">
        <div class="type">
          <xsl:call-template name='TypeDeclaration' />
        </div>
      </xsl:if>

    </xsl:for-each>

  </xsl:template>
  
  <!-- Member declaration (method/event/field/property) -->
  
  <!-- Type Declaration -->
  <xsl:template match='member' name='TypeDeclaration'>
    <xsl:if test="starts-with(@name, 'T')">

      <!-- Save name of type for later use -->
      <xsl:variable name="currentType">
        <xsl:value-of select="concat(substring(@name, 3), '.')" />
      </xsl:variable>
      
      <!-- Print type name and doc-comments -->
      <!-- We use a simple javascript to hide/unhide the members for this type 
           when clicking the type name. -->
      <h2>
        <a href="javascript:;" onmousedown="toggleLayer('{concat($currentType, 'hideable')}')" title="View members">
        <xsl:value-of select='substring(@name, 3)' />
        </a>
      </h2>

      <div id="{concat($currentType, 'hideable')}" style="display:none">
      
      <xsl:call-template name='PrintAllComments' />

      <!-- Print type members -->
      
      <xsl:for-each select='../*'>
        <xsl:sort select='@name' />
        <xsl:if test="starts-with(substring(@name, 3), $currentType)">
          
          <!-- Methods -->
          <xsl:if test="starts-with(@name, 'M')">
            <div class="method">
              <h3>
                Method: <xsl:value-of select="translate(substring(@name, 3 + string-length($currentType)), ',', ', ')" />
              </h3>
              <xsl:call-template name='PrintAllComments' />
            </div>
          </xsl:if>

          <!-- Properties -->
          <xsl:if test="starts-with(@name, 'P')">
            <div class="property">
              <h3>
                Property: <xsl:value-of select="substring(@name, 3 + string-length($currentType))" />
              </h3>
              <xsl:call-template name='PrintAllComments' />
            </div>
          </xsl:if>

          <!-- Fields -->
          <xsl:if test="starts-with(@name, 'F')">
            <div class="field">
              <h3>
                Field: <xsl:value-of select="substring(@name, 3 + string-length($currentType))" />
              </h3>
              <xsl:call-template name='PrintAllComments' />
            </div>
          </xsl:if>

          <!-- Events -->
          <xsl:if test="starts-with(@name, 'E')">
            <div class="event">
              <h3>
                Event: <xsl:value-of select="substring(@name, 3 + string-length($currentType))" />
              </h3>
              <xsl:call-template name='PrintAllComments' />
            </div>
          </xsl:if>
          
        </xsl:if>
        
      </xsl:for-each>

      </div>
      
    </xsl:if>

  </xsl:template>
  
  <xsl:template match="/doc">
    <html>

      <head>
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript">
          <![CDATA[
          function toggleLayer (whichLayer)
          {
            var elem, vis;
            if (document.getElementById)  // Standard compliant
              elem = document.getElementById (whichLayer);
            else if (document.all)        // Old IE
              elem = document.all[whichLayer];
            else if (document.layers)    // Old Netscape
              elem = document.layers[whichLayer];
              
            vis = elem.style;

            if ((vis.display == '') && (elem.offsetWidth != undefined) && (elem.offsetHeight != undefined))
              vis.display = (elem.offsetWidth !=0 && elem.offsetHeight != 0) ? 'block' : 'none';

            vis.display = (vis.display == '' || vis.display == 'block') ? 'none' : 'block';
          }
          ]]>
        </script>

        <title>
          OpenTK function reference
        </title>
      </head>

      <body>
        <h1>
          <xsl:value-of select='assembly'/>
        </h1>

        <xsl:call-template name='DocumentationSection' />
        
      </body>

    </html>
  </xsl:template>
  
</xsl:stylesheet>