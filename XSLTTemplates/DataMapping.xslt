<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:user="http://tempuri.org/msxsl" exclude-result-prefixes="msxsl">
  <xsl:output method="xml" indent="yes"/>

  <msxsl:script language="JScript" implements-prefix="user">
    <![CDATA[
      function getFilename(context)
      {
        return context.nextNode.url;
      }
  ]]>
  </msxsl:script>

  <xsl:template match="/">
    <Root>
      <xsl:call-template name="getDocuments"/>
    </Root>
  </xsl:template>

  <xsl:template name="getDocuments">
    <xsl:param name="fileStartWith" select="'POLCTR_WCU_Audit_Package '"/>
    <xsl:param name="endCounter">3</xsl:param>
    <xsl:param name="startCounter">1</xsl:param>
    <xsl:choose>
      <xsl:when test="$endCounter > 0">
        <xsl:variable name="fileName">
          <xsl:value-of select="concat($fileStartWith ,'(',$startCounter,').xml')"/>
        </xsl:variable>

        <xsl:for-each select="document($fileName)/*">

          <xsl:if test="/CUSTOMER_DATA">
            <File>
              <Name>            
                    
              
              </Name>
              <PKG_NAME>
                <xsl:value-of select="//PKG_NAME"/>
              </PKG_NAME>
              <GUNTHER_PKG_IND>
                <xsl:value-of select="//GUNTHER_PKG_IND"/>
              </GUNTHER_PKG_IND>
              <PKG_TYPE>
                <xsl:value-of select="//PKG_TYPE"/>
              </PKG_TYPE>
              <STATE_OF_COV>
                <xsl:value-of select="//STATE_OF_COV"/>
              </STATE_OF_COV>
              <MULTI_ST_POL_IND>
                <xsl:value-of select="//MULTI_ST_POL_IND"/>
              </MULTI_ST_POL_IND>
              <POL_PK>
                <xsl:value-of select="//POL_PK"/>
              </POL_PK>
              <xsl:for-each select="RECORD_DELIM">
                <POL_FK>
                  <xsl:value-of select="LTR_NAME_REC/POL_FK"/>
                </POL_FK>
                <LTR_NAME_BATCH>
                  <xsl:value-of select="LTR_NAME_REC/LTR_NAME_BATCH"/>
                </LTR_NAME_BATCH>
              </xsl:for-each>
            </File>
          </xsl:if>
          <!--<xsl:if test="//DocumentConfig/FieldConfigSections/FieldConfigSection/Output/Part[@xmlOutNode = 'INBND_DOCTYPE']/@text != ''">           
          </xsl:if>-->
        </xsl:for-each>

        <xsl:call-template name="getDocuments">
          <xsl:with-param name="startCounter" select="$startCounter + 1"/>
          <xsl:with-param name="fileStartWith" select="$fileStartWith"/>
          <xsl:with-param name="endCounter" select="$endCounter - 1"/>
        </xsl:call-template>
      </xsl:when>
    </xsl:choose>
  </xsl:template>

</xsl:stylesheet>
