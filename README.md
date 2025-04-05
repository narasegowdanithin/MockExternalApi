#Mock External API

# Mock External API for Invoice Evaluation

This project includes a mock external API that simulates the classification process for invoices. It is used by the **Invoice Evaluation API** to classify invoices based on their content. This API runs on port `5005`.

## Mock External API Overview

The mock external API mimics a real classification service. It is used during the invoice evaluation process to classify invoices into various categories based on predefined rules. 

### API Endpoint

The mock external API exposes a **GET** endpoint to return classification data for invoices.

#### Endpoint:

#### Response:

The mock external API will return a JSON response containing classification information. Here's an example of the response:

```json
{
  "classification": "WaterLeakDetection",
  "riskLevel": "Low"
}
```


### Key Points in the Section:
- The **Mock External API** runs on port `5005`.
- It exposes a `GET /api/classify` endpoint that returns classification data in JSON format.
- The **Invoice Evaluation API** relies on this service to classify invoices, and the classification data influences the rules applied during invoice evaluation.

