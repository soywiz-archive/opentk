<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match='member' name='TypeDeclaration'>

    <xsl:if test="starts-with(@name, 'T')">

      <xsl:variable name="currentType">
        <xsl:value-of select='substring(@name, 3)' />
      </xsl:variable>
      
      <!-- Print title -->
      <h2>
        <xsl:value-of select='substring(@name, 3)' />
      </h2>
      <!-- Print summary -->
      <xsl:value-of select='summary' />
      <!-- Find and print all members -->
      
      <xsl:for-each select='../*'>
        <xsl:if test="starts-with(substring(@name, 3), $currentType)">
          
          <!-- Methods -->
          <xsl:if test="starts-with(@name, 'M')">
            <h3>Method: <xsl:value-of select="translate(substring(@name, 4 + string-length($currentType)), ',', ', ')" /></h3>
            <xsl:value-of select="." />
          </xsl:if>

          <!-- Properties -->
          <xsl:if test="starts-with(@name, 'P')">
            <h3>
              Property: <xsl:value-of select="substring(@name, 4+string-length($currentType))" />
            </h3>
            <xsl:value-of select="." />
          </xsl:if>

          <!-- Fields -->
          <xsl:if test="starts-with(@name, 'F')">
            <h3>
              Field: <xsl:value-of select="substring(@name, 4+string-length($currentType))" />
            </h3>
            <xsl:value-of select="." />
          </xsl:if>
          
        </xsl:if>
        
      </xsl:for-each>
      
    </xsl:if>

 

  </xsl:template>

  <!-- One section for each type -->
  <xsl:template name='DocumentationSection'>
    
    <!--<xsl:apply-templates select='*/members'/>-->
    <xsl:for-each select='*/members/*'>

      <xsl:sort select='@name'/>
      <xsl:if test="starts-with(@name, 'T')">
        <xsl:call-template name='TypeDeclaration' />
      </xsl:if>
      
    </xsl:for-each>
    
  </xsl:template>
  
  <xsl:template match="/manual">
    <html>

      <head>
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
        <title>
          OpenTK function reference
        </title>
      </head>

      <body>
        <h1>
          <xsl:value-of select='*/assembly'/>
        </h1>

        <xsl:call-template name='DocumentationSection' />
        
        <!--
        <xsl:for-each select='*/members/*'>
          <xsl:sort select='@name'/>
          <xsl:call-template name='Member' />
        </xsl:for-each>
-->    
      </body>

    <!--
        <xsl:for-each select='*/members/member'>
          <xsl:if name='T'>
            <h2>
              <xsl:value-of select='@name'/>
            </h2>
          </xsl:if>
          <xsl:value-of select='summary'/>
        </xsl:for-each>
    -->
    </html>
  </xsl:template>
  
</xsl:stylesheet>