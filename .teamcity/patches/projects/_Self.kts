package patches.projects

import jetbrains.buildServer.configs.kotlin.v2018_1.*
import jetbrains.buildServer.configs.kotlin.v2018_1.Project
import jetbrains.buildServer.configs.kotlin.v2018_1.ui.*

/*
This patch script was generated by TeamCity on settings change in UI.
To apply the patch, change the root project
accordingly, and delete the patch script.
*/
changeProject(DslContext.projectId) {
    features {
        add {
            feature {
                type = "CloudProfile"
                id = "arm-1"
                param("clientId", "0c2be730-4705-41b9-8c15-0ce5959b7152")
                param("secure:clientSecret", "credentialsJSON:e6ba943c-0576-477d-bf5d-d5ed05a5e3af")
                param("profileServerUrl", "")
                param("system.cloud.profile_id", "arm-1")
                param("total-work-time", "15")
                param("credentialsType", "service")
                param("description", "")
                param("cloud-code", "arm")
                param("enabled", "true")
                param("environment", "AZURE")
                param("profileId", "arm-1")
                param("name", "Azure TC Agent")
                param("tenantId", "de9dd080-6e04-4524-9010-e747ec897e4b")
                param("next-hour", "")
                param("subscriptionId", "5e4e5d46-5476-4497-9f78-2a474e8e52ee")
                param("terminate-idle-time", "15")
                param("secure:passwords_data", "")
            }
        }
    }
}