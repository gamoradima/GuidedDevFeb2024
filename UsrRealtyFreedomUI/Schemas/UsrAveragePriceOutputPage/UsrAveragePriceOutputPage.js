define("UsrAveragePriceOutputPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"name": "TopAreaProfileContainer",
				"values": {
					"columns": [
						"minmax(64px, 1fr)",
						"minmax(64px, 1fr)",
						"minmax(64px, 1fr)"
					],
					"visible": true,
					"alignItems": "stretch"
				}
			},
			{
				"operation": "insert",
				"name": "NumberInput_7f7luz6",
				"values": {
					"layoutConfig": {
						"column": 1,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 1
					},
					"type": "crt.NumberInput",
					"label": "$Resources.Strings.PageParameters_UsrIntegerParameter1_6j1ai2s",
					"labelPosition": "auto",
					"control": "$PageParameters_UsrIntegerParameter1_6j1ai2s",
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "TopAreaProfileContainer",
				"propertyName": "items",
				"index": 0
			},
			{
				"operation": "insert",
				"name": "Input_bxkipjf",
				"values": {
					"layoutConfig": {
						"column": 2,
						"row": 1,
						"colSpan": 1,
						"rowSpan": 5
					},
					"type": "crt.Input",
					"label": "$Resources.Strings.PageParameters_UsrTextParameter1_mx01zme",
					"labelPosition": "auto",
					"control": "$PageParameters_UsrTextParameter1_mx01zme",
					"multiline": true,
					"visible": true,
					"readonly": true,
					"placeholder": "",
					"tooltip": ""
				},
				"parentName": "TopAreaProfileContainer",
				"propertyName": "items",
				"index": 1
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"PageParameters_UsrIntegerParameter1_6j1ai2s": {
						"modelConfig": {
							"path": "PageParameters.UsrAvgPriceParameter"
						}
					},
					"PageParameters_UsrTextParameter1_mx01zme": {
						"modelConfig": {
							"path": "PageParameters.UsrSQLTextParameter"
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});